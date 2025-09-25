﻿using ControllerScouting.Gamepad;
using ControllerScouting.Properties;
using ControllerScouting.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace ControllerScouting.Screens
{
    public partial class BaseScreen : Form
    {
        private static bool loading = false;
        private static readonly List<Thread> controllerThreads = [];
        public BaseScreen()
        {
            if (Enum.TryParse<BackgroundCode.EXPORT_TYPE>(BackgroundCode.iniFile.Read("ProgramSettings", "exportType", ""), out var exportType))
            {
                BackgroundCode.dataExport = exportType;
            }
            else
            {
                BackgroundCode.dataExport = BackgroundCode.EXPORT_TYPE.CSV;
            }
            Settings.Default.CSVLocation = BackgroundCode.iniFile.Read("ProgramSettings", "csvLocation", "");

            if (BackgroundCode.dataExport == BackgroundCode.EXPORT_TYPE.CSV)
            {
                Settings.Default.csvExists = DatabaseCode.DoesCSVExist(Settings.Default.CSVLocation);
            }

            //Initialization of the screen
            InitializeComponent();

            //Sets the default values for the robots
            for (int i = 0; i < 6; i++)
            {
                BackgroundCode.Robots[i] = new RobotState
                {
                    ScouterBox = i,
                    _ScouterName = RobotState.SCOUTER_NAME.Select_Name,
                    color = i < 3 ? "Red" : "Blue"
                };

                BackgroundCode.activity_record[i] = new Activity();
            }

            BackgroundCode.gamePads = BackgroundCode.controllers.GetGamePads();
            // Create and start a new thread for each controller
            StartControllerThreads();

            InitalizeDB();

            //If there is previous data, ask if the user wants to load it
            if (BackgroundCode.iniFile.Read("MatchData", "event", "") != null && BackgroundCode.iniFile.Read("MatchData", "event", "") != "" && BackgroundCode.iniFile.Read("MatchData", "event", "") != " ")
            {
                DialogResult loadPrevData = MessageBox.Show("Do you want to load previous data?", "Please Confirm", MessageBoxButtons.YesNo);
                if (loadPrevData == DialogResult.Yes)
                {
                    LoadData();
                }
            }

            timerJoysticks.Interval = 20;
            timerJoysticks.Tick += new EventHandler(this.UpdateScreen);
            timerJoysticks.Enabled = true;

            Thread statusLightThread = new(() => StatusLightThread());
            statusLightThread.Start();
        }

        private void StatusLightThread()
        {
            while (true)
            {
                //Check the fore color of status light in the top right corner, if red, make it green. If green, make it red.
                if (this.statusLight.BackColor == Color.Green)
                {
                    this.statusLight.BackColor = Color.Red;
                }
                else
                {
                    this.statusLight.BackColor = Color.Green;
                }

                Thread.Sleep(500);
            }
        }
        private static void ControllerThreadMethod(GamePad gamePad)
        {
            // Logic to handle the controller
            while (true)
            {
                // Read and process the controller input
                if (gamePad != null) BackgroundCode.controllers.ReadStick(gamePad, Array.IndexOf(BackgroundCode.gamePads, gamePad));
            }
        }

        private static void InitalizeDB()
        {
            if (Settings.Default.sqlExists)
            {
                // Sets the connection string to the database
                BackgroundCode.seasonframework.Database.Connection.ConnectionString = Settings.Default._scoutingdbConnectionString;

                // initializes the database
                BackgroundCode.seasonframework.Database.Initialize(true);
            }
        }

        public static void UpdateJoysticks()
        {
            foreach (Thread thread in controllerThreads)
            {
                thread.Abort();
            }
            //Updates the list of currently connected gamepads
            BackgroundCode.gamePads = BackgroundCode.controllers.GetGamePads();
            StartControllerThreads();
        }
        private static void StartControllerThreads()
        {
            foreach (GamePad gamePad in BackgroundCode.gamePads)
            {
                if (gamePad != null)
                {
                    Thread controllerThread = new(() => ControllerThreadMethod(gamePad));
                    controllerThread.Start();
                    controllerThreads.Add(controllerThread);
                }
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Makes sure the user wants to exit
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Please Confirm", MessageBoxButtons.YesNo);
            if (confirmExit == DialogResult.Yes)
            {
                //If the event is loaded or manual matches are loaded, ask if the user wants to save the data
                if (BackgroundCode.loadedEvent != null || BackgroundCode.manualMatchList != null)
                {
                    confirmExit = MessageBox.Show("Do you want to save the current data?", "Please Confirm", MessageBoxButtons.YesNo);
                    if (confirmExit == DialogResult.Yes)
                    {
                        //Save the data
                        SaveData();
                    }
                }

                //Close the connection then exit
                if (Settings.Default.sqlExists) 
                {
                    BackgroundCode.seasonframework.Database.Connection.Close();
                }
                Environment.Exit(0);
            }
        }
        private void SaveData()
        {
            if ((BackgroundCode.loadedEvent != null || BackgroundCode.manualMatchList != null) && BackgroundCode.currentMatch != 0)
            {
                try
                {
                    // Write data to INI file
                    if (BackgroundCode.loadedEvent == null)
                    {
                        BackgroundCode.iniFile.Write("MatchData", "event", "manualEvent");
                    }
                    else
                    {
                        BackgroundCode.iniFile.Write("MatchData", "event", BackgroundCode.loadedEvent);
                    }
                    BackgroundCode.iniFile.Write("MatchData", "match_number", BackgroundCode.currentMatch.ToString());
                    BackgroundCode.iniFile.Write("MatchData", "redRight", BackgroundCode.redRight.ToString());
                    BackgroundCode.iniFile.Write("MatchData", "teamPrio", string.Join(",", BackgroundCode.teamPrio));
                    BackgroundCode.iniFile.Write("MatchData", "homeTeam", BackgroundCode.homeTeam);
                    string scouterNames = "";
                    string scouterLocations = "";
                    foreach (var robot in BackgroundCode.Robots)
                    {
                        if (scouterNames.Length != 0)
                        {
                            scouterNames += ",";
                        }
                        scouterNames += robot.GetScouterName();

                        if (scouterLocations.Length != 0)
                        {
                            scouterLocations += ",";
                        }
                        scouterLocations += robot.ScouterBox;
                    }
                    BackgroundCode.iniFile.Write("MatchData", "scouterNames", scouterNames);
                    BackgroundCode.iniFile.Write("MatchData", "scouterLocations", scouterLocations);

                    string matches = "";
                    foreach (var match in BackgroundCode.InMemoryMatchList)
                    {
                        if (matches.Length != 0)
                        {
                            matches += ",";
                        }
                        matches += $"{match.Blueteam1};{match.Blueteam2};{match.Blueteam3};{match.Redteam1};{match.Redteam2};{match.Redteam3}";
                    }
                    BackgroundCode.iniFile.Write("EventData", "Matches", matches);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No data to save.");
            }
        }
        private void LoadData()
        {
            try
            {
                comboBoxSelectRegional.Items.Add(BackgroundCode.iniFile.Read("MatchData", "event", "Please press the Load Events Button..."));
                comboBoxSelectRegional.SelectedItem = BackgroundCode.iniFile.Read("MatchData", "event", "Please press the Load Events Button...");
                BackgroundCode.currentMatch = int.Parse(BackgroundCode.iniFile.Read("MatchData", "match_number", "")) - 1;
                BackgroundCode.redRight = bool.Parse(BackgroundCode.iniFile.Read("MatchData", "redRight", ""));
                var teamPrioList = new List<string>(BackgroundCode.iniFile.Read("MatchData", "teamPrio", "").Split(','));
                BackgroundCode.teamPrio.AddRange([.. teamPrioList]);
                BackgroundCode.homeTeam = BackgroundCode.iniFile.Read("MatchData", "homeTeam", "None");
                BackgroundCode.loadedEvent = BackgroundCode.iniFile.Read("MatchData", "event", "");


                List<string> scouterNames = [.. BackgroundCode.iniFile.Read("MatchData", "scouterNames", "").Split(',')];
                List<string> scouterLocations = [.. BackgroundCode.iniFile.Read("MatchData", "scouterLocations", "").Split(',')];

                for (int i = 0; i < 6; i++)
                {
                    BackgroundCode.Robots[i]._ScouterName = (RobotState.SCOUTER_NAME)Enum.Parse(typeof(RobotState.SCOUTER_NAME), scouterNames[i]);
                    BackgroundCode.Robots[i].ScouterBox = int.Parse(scouterLocations[i]);
                }

                BackgroundCode.InMemoryMatchList = DatabaseCode.ListToMatch(BackgroundCode.iniFile.Read("EventData", "Matches", "").Split(','));

                if (Settings.Default.sqlExists)
                {
                    BackgroundCode.seasonframework.Database.Connection.Close();
                }

                if (comboBoxSelectRegional.SelectedItem.ToString() == "manualEvent")
                {
                    DatabaseCode.LoadManualMatches();
                }

                NextMatch();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not load data.", "Error: " + e);
            }
        }
        private void BtnInitialDBLoad_Click(object sender, EventArgs e)
        {
            if (Settings.Default.sqlExists)
            {
                BackgroundCode.seasonframework.Database.Connection.Close();
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to load The Blue Alliance data?", "Please Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Settings.Default.sqlExists)
                {
                    BackgroundCode.seasonframework.Database.Connection.Open();
                }
                GetEvents(false);
                SetRedRight();

                Log("Start time is " + DateTime.Now.TimeOfDay);
            }
            else
            {
                DialogResult manualMatches = MessageBox.Show("Do you want to load manual matches?", "Please Confirm", MessageBoxButtons.YesNo);
                if (manualMatches == DialogResult.Yes)
                {
                    SetRedRight();
                    Log("Loading manual matches.");
                    DatabaseCode.LoadManualMatches();
                    comboBoxSelectRegional.DataSource = null;
                    comboBoxSelectRegional.Items.Clear();
                    comboBoxSelectRegional.Items.Add("manualEvent");
                    comboBoxSelectRegional.SelectedItem = "manualEvent";
                }
            }
        }
        private void SetRedRight()
        {
            //  Logic for setting left/right and near/far based on side of field scouters are sitting on
            DialogResult red = MessageBox.Show("Is the Red Alliance on your right?", "Please Confirm", MessageBoxButtons.YesNo);
            BackgroundCode.redRight = (red == DialogResult.Yes);
        }

        private void BtnNextMatch_Click(object sender, EventArgs e)
        {
            if (cbxEndMatch.Checked)
            {
                cbxEndMatch.Checked = false;
                for (int i = 0; i < BackgroundCode.gamePads.Length; i++)
                {
                    DatabaseCode.SaveToRecord(BackgroundCode.Robots[BackgroundCode.Robots[i].ScouterBox], "EndMatch", i);
                }

                if (BackgroundCode.currentMatch == BackgroundCode.InMemoryMatchList.Count)
                {
                    MessageBox.Show("You are at the last match.");
                }
                else
                {
                    NextMatch();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("All unsaved data will be lost.  Continue?", "Next Match", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes && BackgroundCode.currentMatch != BackgroundCode.InMemoryMatchList.Count)
                {
                    for (int i = 0; i < BackgroundCode.gamePads.Length; i++)
                    {
                        if (BackgroundCode.gamePads[i] != null)
                        {
                            BackgroundCode.Robots[i].ResetScouter();
                        }
                    }

                    NextMatch();
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < BackgroundCode.gamePads.Length; i++)
                    {
                        if (BackgroundCode.gamePads[i] != null)
                        {
                            BackgroundCode.Robots[i].ResetScouter();
                        }
                    }

                    MessageBox.Show("You are at the last match.");
                }
            }
        }

        private void NextMatch()
        {
            BackgroundCode.currentMatch++;
            LoadMatch();
        }

        private void BtnPrevMatch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BackgroundCode.gamePads.Length; i++)
            {
                if (BackgroundCode.gamePads[i] != null)
                {
                    BackgroundCode.Robots[i].ResetScouter();
                }
            }

            if (BackgroundCode.currentMatch == 0 || BackgroundCode.currentMatch == 1)
            {
                MessageBox.Show("You are at the first match.");
            }
            else
            {
                BackgroundCode.currentMatch--;

                LoadMatch();
            }
        }
        private void LoadMatch()
        {
            SetTeamNameAndColor(this.lbl0TeamName, BackgroundCode.Robots[0], BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Redteam1);
            SetTeamNameAndColor(this.lbl1TeamName, BackgroundCode.Robots[1], BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Redteam2);
            SetTeamNameAndColor(this.lbl2TeamName, BackgroundCode.Robots[2], BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Redteam3);
            SetTeamNameAndColor(this.lbl3TeamName, BackgroundCode.Robots[3], BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Blueteam1);
            SetTeamNameAndColor(this.lbl4TeamName, BackgroundCode.Robots[4], BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Blueteam2);
            SetTeamNameAndColor(this.lbl5TeamName, BackgroundCode.Robots[5], BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Blueteam3);
            
            this.lblMatch.Text = $"{BackgroundCode.currentMatch}/{BackgroundCode.InMemoryMatchList.Count}";
        }
        private void SetTeamNameAndColor(Label label, RobotState robot, string teamName)
        {
            label.Text = robot.TeamName = teamName;
            label.ForeColor = Color.Orange;
        }

        private async void BtnpopulateForEvent_Click(object sender, EventArgs e)
        {
            if (!loading)
            {
                loading = true;
                BackgroundCode.UnSortedMatchList.Clear();
                BackgroundCode.InMemoryMatchList.Clear();
                if (BackgroundCode.manualMatchList != null)
                {
                    List<string> manualTeams = [];

                    for (int i = 0; i < BackgroundCode.manualMatchList.Count; i++)
                    {
                        Match matchData = new()
                        {
                            Match_number = i,
                            Set_number = i,
                            Key = "manualevent",
                            Comp_level = "qm",
                            Event_key = "manualevent",

                            Blueteam1 = "frc" + BackgroundCode.manualMatchList[i][0],
                            Blueteam2 = "frc" + BackgroundCode.manualMatchList[i][1],
                            Blueteam3 = "frc" + BackgroundCode.manualMatchList[i][2],
                            Redteam1 = "frc" + BackgroundCode.manualMatchList[i][3],
                            Redteam2 = "frc" + BackgroundCode.manualMatchList[i][4],
                            Redteam3 = "frc" + BackgroundCode.manualMatchList[i][5]
                        };

                        BackgroundCode.UnSortedMatchList.Add(matchData);
                        BackgroundCode.InMemoryMatchList.Add(matchData);

                        BackgroundCode.MatchNumbers.Add(i + 1);

                        for (int j = 0; j < BackgroundCode.manualMatchList[i].Count; j++)
                        {
                            if (!manualTeams.Contains(BackgroundCode.manualMatchList[i][j]))
                            {
                                manualTeams.Add(BackgroundCode.manualMatchList[i][j]);
                            }
                        }
                    }

                    BackgroundCode.InMemoryMatchList = [.. BackgroundCode.UnSortedMatchList.OrderBy(o => o.Match_number)];
                    
                    string matches = "";
                    foreach (var match in BackgroundCode.InMemoryMatchList)
                    {
                        if (matches.Length != 0)
                        {
                            matches += ",";
                        }
                        matches += $"{match.Blueteam1};{match.Blueteam2};{match.Blueteam3};{match.Redteam1};{match.Redteam2};{match.Redteam3}";
                    }
                    BackgroundCode.iniFile.Write("EventData", "Matches", matches);


                    foreach (var team in manualTeams)
                    {
                        TeamSummary teamData = new()
                        {
                            Team_key = "frc" + team,
                            Team_number = team,
                            Event_key = "manualevent",
                            Nickname = "manualevent"
                        };

                        BackgroundCode.teamlist.Add(team);
                    }
                }
                else if (this.comboBoxSelectRegional.Text == "Please press the Load Events Button...")
                {
                    MessageBox.Show("You must load an event first.", "Not Ready to Get Matches");
                    return;
                }
                else
                {
                    try
                    {
                        BackgroundCode.loadedEvent = comboBoxSelectRegional.SelectedItem.ToString();
                        regional = BackgroundCode.loadedEvent.TrimStart('[');
                        int index = regional.IndexOf(",");
                        if (index > 0) regional = regional.Substring(0, index);

                        string uri = $"https://www.thebluealliance.com/api/v3/event/{DateTime.Now.Year}{regional}/teams?X-TBA-Auth-Key={Settings.Default.API_KEY}";

                        using (HttpClient client = new())
                        {
                            try
                            {
                                HttpResponseMessage response = await client.GetAsync(uri);
                                response.EnsureSuccessStatusCode(); // Throw if not a success code.

                                string responseFromServer = await response.Content.ReadAsStringAsync();
                                //Log("Response from Server -> " + responseFromServer);
                                //Console.Write(responseFromServer);

                                List<TeamSummary> JSONteams = JsonConvert.DeserializeObject<List<TeamSummary>>(responseFromServer);
                                Log("Received " + JSONteams.Count + " teams for " + regional + ".");

                                // Clear the existing team list
                                BackgroundCode.teamlist.Clear();

                                foreach (var item in JSONteams)
                                {
                                    BackgroundCode.teamlist.Add(item.Team_number);
                                }
                                Log("Teams -> " + string.Join(", ", JSONteams.Select(item => item.Team_number)));
                            }
                            catch (HttpRequestException)
                            {
                                loading = false;
                            }
                        }

                        string matchesuri = $"https://www.thebluealliance.com/api/v3/event/{DateTime.Now.Year}{regional}/matches?X-TBA-Auth-Key={Settings.Default.API_KEY}";

                        using (HttpClient client = new())
                        {
                            try
                            {
                                HttpResponseMessage response = await client.GetAsync(matchesuri);
                                response.EnsureSuccessStatusCode(); // Throw if not a success code.

                                string responseFromServer = await response.Content.ReadAsStringAsync();

                                List<Match> JSONmatches = JsonConvert.DeserializeObject<List<Match>>(responseFromServer);
                                dynamic obj = JsonConvert.DeserializeObject(responseFromServer);

                                int MatchCount = 0;
                                BackgroundCode.MatchNumbers.Clear();

                                for (int i = 0; i < JSONmatches.Count; i++)
                                {
                                    if (JSONmatches[i].Comp_level == "qm")
                                    {
                                        Match match_record = new();

                                        MatchCount++;
                                        BackgroundCode.MatchNumbers.Add(MatchCount);
                                        BackgroundCode.InMemoryMatchList.Add(JSONmatches[i]);

                                        dynamic alliances = obj[i].alliances;
                                        dynamic bluealliance = alliances.blue;
                                        dynamic redalliance = alliances.red;

                                        dynamic blueteamsobj = bluealliance.team_keys;
                                        dynamic redteamsobj = redalliance.team_keys;

                                        match_record.Match_number = (int)obj[i].match_number;

                                        match_record.Set_number = obj[i].match_number;

                                        match_record.Key = obj[i].key;
                                        match_record.Comp_level = obj[i].comp_level;
                                        match_record.Event_key = obj[i].event_key;
                                        match_record.Blueteam1 = blueteamsobj[0];
                                        match_record.Blueteam2 = blueteamsobj[1];
                                        match_record.Blueteam3 = blueteamsobj[2];
                                        match_record.Redteam1 = redteamsobj[0];
                                        match_record.Redteam2 = redteamsobj[1];
                                        match_record.Redteam3 = redteamsobj[2];

                                        BackgroundCode.UnSortedMatchList.Add(match_record);
                                    }
                                }
                                Log($"{BackgroundCode.UnSortedMatchList.Count} matches");
                            }
                            catch (HttpRequestException)
                            {
                                loading = false;
                            }
                        }

                        BackgroundCode.InMemoryMatchList = [.. BackgroundCode.UnSortedMatchList.OrderBy(o => o.Match_number)];
                    }
                    catch
                    {
                        MessageBox.Show("Please select an event from the drop down.");
                    }
                }
                try
                {
                    BackgroundCode.currentMatch = 0;
                    loading = false;
                    NextMatch();
                }
                catch { }
            }
        }
        private async void GetEvents(bool isManual)
        {
            if (isManual)
            {
                DatabaseCode.LoadManualMatches();
            }
            else
            {
                string uri = $"https://www.thebluealliance.com/api/v3/events/{DateTime.Now.Year}?X-TBA-Auth-Key={Settings.Default.API_KEY}";

                using HttpClient client = new();
                try
                {
                    HttpResponseMessage response = await client.GetAsync(uri);
                    response.EnsureSuccessStatusCode(); // Throw if not a success code.

                    string responseFromServer = await response.Content.ReadAsStringAsync();

                    List<EventSummary> JSONevents = JsonConvert.DeserializeObject<List<EventSummary>>(responseFromServer);
                    List<KeyValuePair<string, string>> elist = [];

                    foreach (var item in JSONevents)
                    {
                        elist.Add(new KeyValuePair<string, string>(item.Event_code, $"{item.Event_code} - {item.Name}"));
                    }
                    this.comboBoxSelectRegional.DataSource = elist;
                }
                catch (HttpRequestException)
                {
                    DialogResult manualMatches = MessageBox.Show("Do you want to load manual matches?", "Error loading Blue Alliance data.", MessageBoxButtons.YesNo);
                    if (manualMatches == DialogResult.Yes)
                    {
                        DatabaseCode.LoadManualMatches();
                        comboBoxSelectRegional.Items.Add("manualEvent");
                        comboBoxSelectRegional.SelectedItem = "manualEvent";
                    }
                }
            }
        }
        public static void RefreshPrio()
        {
            if (BackgroundCode.homeTeam != "None")
            {
                for (int i = BackgroundCode.currentMatch - 1; i < BackgroundCode.InMemoryMatchList.Count; i++)
                {
                    if (i > 0)
                    {
                        List<string> teams =
                            [
                                BackgroundCode.InMemoryMatchList[i].Redteam1.Substring(3),
                                BackgroundCode.InMemoryMatchList[i].Redteam2.Substring(3),
                                BackgroundCode.InMemoryMatchList[i].Redteam3.Substring(3),
                                BackgroundCode.InMemoryMatchList[i].Blueteam1.Substring(3),
                                BackgroundCode.InMemoryMatchList[i].Blueteam2.Substring(3),
                                BackgroundCode.InMemoryMatchList[i].Blueteam3.Substring(3)
                            ];

                        if (teams.Contains(BackgroundCode.homeTeam))
                        {
                            BackgroundCode.homePrio.Clear();
                            BackgroundCode.homePrio.AddRange(teams);
                            BackgroundCode.homePrio.Remove(BackgroundCode.homeTeam);
                            break;
                        }
                    }
                }
            }
        }

        private void Log(string m)
        {
            Logger.Log(m);
        }

        private void BtnFunctions_Click(object sender, EventArgs e)
        {
            FunctionsForm frm = new();
            frm.Show();
        }


        readonly Dictionary<int, string> DefenseEquality = new()
        {
            { 0, "None" },
            { 1, "1 Station" },
            { 2, "2 Stations" },
            { 3, "Chasing" },
            { 4, "Counter" },
            { 9, "Scouter Error" }
        };
        readonly Dictionary<int, string> AvoidanceEquality = new()
        {
            { 0, "None" },
            { 1, "1 Station" },
            { 2, "2 Stations" },
            { 3, "Chasing" },
            { 4, "Counter" },
            { 9, "Scouter Error" }
        };
        private void UpdateScreen(object sender, EventArgs e)
        {
            int redScore = 0;
            int blueScore = 0;
            //Loops through all 6 boxes to update the text to be based on the RobotState
            for (int i = 0; i < 6; i++)
            {
                RobotState robot = BackgroundCode.Robots[i];
                int robotBox = robot.ScouterBox;
                switch (BackgroundCode.Robots[i].Current_Mode)
                {
                    case RobotState.ROBOT_MODE.Auto:
                        InAutoMode(i, robotBox);
                        break;
                    case RobotState.ROBOT_MODE.Teleop:
                        InTeleopMode(i, robotBox);
                        break;
                    case RobotState.ROBOT_MODE.Defense:
                        InDefenseMode(i, robotBox);
                        break;
                    case RobotState.ROBOT_MODE.Surfacing:
                        InSurfacingMode(i, robotBox);
                        break;
                }

                if (i < 3)
                {
                    redScore += BackgroundCode.Robots[i].PointsScored;
                }
                else
                {
                    blueScore += BackgroundCode.Robots[i].PointsScored;
                }

                ((Label)this.Controls.Find($"lbl{robot.ScouterBox}ScoutName", true)[0]).Text = robot.GetScouterName().ToString();
                ((Label)this.Controls.Find($"lbl{robot.ScouterBox}ScoutName", true)[0]).Visible = true;
                ((Label)this.Controls.Find($"lbl{robot.ScouterBox}MatchEvent", true)[0]).Text = robot.Match_event.ToString();
                ((Label)this.Controls.Find($"lbl{robot.ScouterBox}MatchEvent", true)[0]).Visible = true;
                ((Label)this.Controls.Find($"lbl{robot.ScouterBox}ModeValue", true)[0]).Text = robot.Current_Mode.ToString() + " Mode";
                ((Label)this.Controls.Find($"lbl{robot.ScouterBox}ModeValue", true)[0]).Visible = true;

                ((Label)this.Controls.Find($"lbl{robot.ScouterBox}TeamName", true)[0]).Visible = true;
            }

            ((Label)this.Controls.Find($"lblRedScore", true)[0]).Text = redScore.ToString();
            ((Label)this.Controls.Find($"lblBlueScore", true)[0]).Text = blueScore.ToString();
        }
        private void InAutoMode(int Box_Number, int ScouterBox)
        {
            //Leave
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Text = "Leave:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Visible = true;

            if (BackgroundCode.Robots[Box_Number].Leave == RobotState.LEAVE.Y)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else if (BackgroundCode.Robots[Box_Number].Leave == RobotState.LEAVE.N)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).BackColor = System.Drawing.Color.Yellow;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).Visible = true;

            //Near Far
            if (BackgroundCode.Robots[Box_Number].DelNearFar)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Far Side";
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Near Side";
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Visible = true;

            //Coral
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Text = "Coral:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Visible = true;
            if (BackgroundCode.Robots[Box_Number].hasCoral == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Algae
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).ForeColor = BackgroundCode.Robots[Box_Number].DisFlag ? System.Drawing.Color.Yellow : System.Drawing.Color.White;
            if (BackgroundCode.Robots[Box_Number].hasAlgae == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Attempt
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Text = "End State:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].End_State.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Starting Location
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Text = "Start:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Starting_Location.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Effectiveness
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Text = "Eff:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Def_Eff.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Avoidance Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Text = "Avoid:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Avo_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //End State
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Text = "Attempt:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cage_Attempt.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Robot Strategy
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Text = "Strat:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].GetStrat().ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
        }
        private void InTeleopMode(int Box_Number, int ScouterBox)
        {
            //Leave
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Text = "Leave:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).Visible = false;

            //Near Far
            if (BackgroundCode.Robots[Box_Number].DelNearFar)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Far Side";
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Near Side";
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Visible = true;

            //Coral
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Text = "Coral:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Visible = true;
            if (BackgroundCode.Robots[Box_Number].hasCoral == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Algae
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).ForeColor = BackgroundCode.Robots[Box_Number].DisFlag ? System.Drawing.Color.Yellow : System.Drawing.Color.White;
            if (BackgroundCode.Robots[Box_Number].hasAlgae == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Attempt
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Text = "End State:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].End_State.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Text = "Def:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Def_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Effectiveness
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Text = "Eff:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Def_Eff.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Avoidance Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Text = "Avoid:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Avo_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //End State
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Text = "Attempt:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cage_Attempt.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Robot Strategy
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Text = "Strat:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].GetStrat().ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
        }
        private void InDefenseMode(int Box_Number, int ScouterBox)
        {
            //Defense Timer
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Text = BackgroundCode.Robots[Box_Number].DefTime_StopWatch.Elapsed.ToString(@"m\:ss\.fff");

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).Visible = false;

            //Near Far
            if (BackgroundCode.Robots[Box_Number].DelNearFar)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Far Side";
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Near Side";
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Visible = true;

            //Coral
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Text = "Coral:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Visible = true;
            if (BackgroundCode.Robots[Box_Number].hasCoral == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Algae
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).ForeColor = BackgroundCode.Robots[Box_Number].DisFlag ? System.Drawing.Color.Yellow : System.Drawing.Color.White;
            if (BackgroundCode.Robots[Box_Number].hasAlgae == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Attempt
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Text = "End State:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].End_State.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Text = "Def:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Def_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Effectiveness
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Text = "Eff:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Def_Eff.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Avoidance Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Text = "Avoid:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Avo_Rat.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //End State
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Text = "Attempt:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cage_Attempt.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Robot Strategy
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Text = "Strat:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].GetStrat().ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Visible = false;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
        }
        private void InSurfacingMode(int Box_Number, int ScouterBox)
        {
            //Climb Timer
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Text = BackgroundCode.Robots[Box_Number].ClimbT_StopWatch.Elapsed.ToString(@"m\:ss\.fff");
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position0Value", true)[0]).Visible = false;

            //Near Far
            if (BackgroundCode.Robots[Box_Number].DelNearFar)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Far Side";
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Text = "Near Side";
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position1", true)[0]).Visible = false;

            //Coral
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Text = "Coral:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2", true)[0]).Visible = true;
            if (BackgroundCode.Robots[Box_Number].hasCoral == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastCoralLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position2Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Algae
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Text = "Algae:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3", true)[0]).ForeColor = BackgroundCode.Robots[Box_Number].DisFlag ? System.Drawing.Color.Yellow : System.Drawing.Color.White;
            if (BackgroundCode.Robots[Box_Number].hasAlgae == 1)
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Green;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Green;
            }
            else
            {
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).ForeColor = System.Drawing.Color.Red;
                ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).BackColor = System.Drawing.Color.Red;
            }
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Value", true)[0]).Visible = true;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeAcqLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Source", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Text = BackgroundCode.Robots[Box_Number].lastAlgaeLoc;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position3Des", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Attempt
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Text = "End State:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].End_State.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position4Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Text = "Def:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Text = DefenseEquality[BackgroundCode.Robots[Box_Number].Def_Rat];
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).Visible = BackgroundCode.Robots[Box_Number].Def_Rat != 9;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position5Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Defense Effectiveness
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Text = "Eff:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7", true)[0]).Visible = BackgroundCode.Robots[Box_Number].Def_Rat != 9 && BackgroundCode.Robots[Box_Number].Def_Rat != 0;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Def_Eff.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).Visible = BackgroundCode.Robots[Box_Number].Def_Eff != 9 && BackgroundCode.Robots[Box_Number].Def_Rat != 9 && BackgroundCode.Robots[Box_Number].Def_Rat != 0;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position7Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Avoidance Rating
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Text = "Avoid:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Text = AvoidanceEquality[BackgroundCode.Robots[Box_Number].Avo_Rat];
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).Visible = BackgroundCode.Robots[Box_Number].Avo_Rat != 9;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position8Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //End State
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Text = "Attempt:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].Cage_Attempt.ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position11Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;

            //Robot Strategy
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Text = "Strat:";
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Text = BackgroundCode.Robots[Box_Number].GetStrat().ToString();
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).Visible = true;
            ((Label)this.Controls.Find($"lbl{ScouterBox}Position12Value", true)[0]).ForeColor = System.Drawing.Color.Yellow;
        }
    }
}