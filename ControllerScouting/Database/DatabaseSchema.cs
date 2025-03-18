using ControllerScouting.Gamepad;
using ControllerScouting.Properties;
using ControllerScouting.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ControllerScouting
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }

    internal class SeasonContext : DbContext
    {
        public SeasonContext()
            : base(Settings.Default._scoutingdbConnectionString)
        { }

        public DbSet<EventSummary> Eventset { get; set; }
        public DbSet<TeamSummary> Teamset { get; set; }
        public DbSet<Match> Matchset { get; set; }
        public DbSet<Activity> ActivitySet { get; set; }
        public DbSet<UpdatePreview> UpdatePreviewSet { get; set; }
    }

    public class Activity : BaseEntity
    {
        //Data elements used in multiple modes (Auto, Auto and/or Showtime)
        //Record Type = Transaction

        //2025
        public string Team { get; set; }
        public int Match { get; set; }
        public DateTime Time { get; set; }
        public string RecordType { get; set; }
        public string Mode { get; set; }
        public string DriveSta { get; set; }
        public string Defense { get; set; }
        public string DefenseValue { get; set; }
        public string Avoidance { get; set; }
        public string ScouterName { get; set; }
        public long ScouterError { get; set; }
        public string Match_event { get; set; }

        public string Strategy { get; set; }
        public int Coop { get; set; }
        public double DZTime { get; set; }
        public string Del_Near_Far { get; set; }
        public string AcqAlgae_Near_Far { get; set; }
        public string AcqCoral_Near_Far { get; set; }

        public string Starting_Loc { get; set; }
        public string Leave { get; set; }

        public int AcqCoralS { get; set; }
        public int AcqCoralF { get; set; }
        public int AcqAlgaeR { get; set; }
        public int AcqAlgaeF { get; set; }

        public int DelCoralL1 { get; set; }
        public int DelCoralL2 { get; set; }
        public int DelCoralL3 { get; set; }
        public int DelCoralL4 { get; set; }
        public int DelCoralF { get; set; }

        public int DelAlgaeP { get; set; }
        public int DelAlgaeN { get; set; }
        public int DelAlgaeF { get; set; }

        public double ClimbT { get; set; }
        public string EndState { get; set; }
        public string CageAttempt { get; set; }
        public string SelectedCage { get; set; }
        public string PointScored { get; set; }
        public int DisAlg { get; set; }

        //Examples from previous years
        //public TimeSpan Cycle { get; set; }
        //public DateTime AcquireTime { get; set; }
        //public DateTime DeliverTime { get; set; }
        //public Decimal score_contribution { get; set; }
    }

    public class UpdatePreview : BaseEntity
    {
        //2025
        public string Team { get; set; }
        public int Match { get; set; }
        public DateTime Time { get; set; }
        public string RecordType { get; set; }
        public string Mode { get; set; }
        public string DriveSta { get; set; }
        public string Defense { get; set; }
        public string DefenseValue { get; set; }
        public string Avoidance { get; set; }
        public string ScouterName { get; set; }
        public long ScouterError { get; set; }
        public string Match_event { get; set; }

        public string Strategy { get; set; }
        public int Coop { get; set; }
        public double DZTime { get; set; }
        public string Del_Near_Far { get; set; }
        public string AcqAlgae_Near_Far { get; set; }
        public string AcqCoral_Near_Far { get; set; }

        public string Starting_Loc { get; set; }
        public string Leave { get; set; }

        public int AcqCoralS { get; set; }
        public int AcqCoralF { get; set; }
        public int AcqAlgaeR { get; set; }
        public int AcqAlgaeF { get; set; }

        public int DelCoralL1 { get; set; }
        public int DelCoralL2 { get; set; }
        public int DelCoralL3 { get; set; }
        public int DelCoralL4 { get; set; }
        public int DelCoralF { get; set; }

        public int DelAlgaeP { get; set; }
        public int DelAlgaeN { get; set; }
        public int DelAlgaeF { get; set; }

        public double ClimbT { get; set; }
        public string EndState { get; set; }
        public string CageAttempt { get; set; }
        public string SelectedCage { get; set; }
        public string PointScored { get; set; }
        public int DisAlg { get; set; }
    }
    public class EventSummary : BaseEntity
    {
        public string Key { get; set; }
        public string Website { get; set; }
        public bool Official { get; set; }
        public string End_date { get; set; }
        public string Name { get; set; }
        public string Short_name { get; set; }
        public string Facebook_eid { get; set; }
        public string Event_district_string { get; set; }
        public string Venue_address { get; set; }
        public int Event_district { get; set; }
        public String Week { get; set; }
        public string Location { get; set; }
        public string Event_code { get; set; }
        public int Year { get; set; }
        public List<object> Webcast { get; set; }
        public string Timezone { get; set; }
        public List<object> Alliances { get; set; }
        public string Event_type_string { get; set; }
        public string Start_date { get; set; }
        public int Event_type { get; set; }
    }

    public class TeamSummary : BaseEntity
    {
        /* UNUSED DATA AVAILABLE FROM TBA
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string gmaps_place_id { get; set; }
        public string gmaps_url { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string location_name { get; set; }
        public string motto { get; set; }
        public string name { get; set; }
        public string nickname { get; set; }
        public string postal_code { get; set; }
        public string rookie_year { get; set; }
        public string school_name { get; set; }
        public string state_prov { get; set; }
        public string website { get; set; }         */
        public string Event_key { get; set; }
        public string Team_key { get; set; }
        public string Team_number { get; set; }
        public string Nickname { get; set; }
    }

    public class Match : BaseEntity
    {
        public string Comp_level { get; set; }
        public int Match_number { get; set; }
        public List<object> Videos { get; set; }
        public object Time_string { get; set; }
        public int Set_number { get; set; }
        public string Key { get; set; }
        public string Time { get; set; }
        public string Blueteam1 { get; set; }
        public string Blueteam2 { get; set; }
        public string Blueteam3 { get; set; }
        public string Redteam1 { get; set; }
        public string Redteam2 { get; set; }
        public string Redteam3 { get; set; }
        public string Event_key { get; set; }
        public int Pointscorered { get; set; }
        public int Redfouls { get; set; }
        public int Pointscoreblue { get; set; }
        public int Bluefouls { get; set; }
        public int Blueauto { get; set; }
        public int Redauto { get; set; }
        public int Bluecharge { get; set; }
        public int Redcharge { get; set; }
        public int Bluetotaldel { get; set; }
        public int Redtotaldel { get; set; }
    }

    public class DatabaseCode
    {
        public static void RecordToDatabase()
        {
            while (1 == 1)
            {
                if (BackgroundCode.activitiesQueue.Count != 0)
                {
                    //Save Record to the database
                    BackgroundCode.seasonframework.ActivitySet.Add(BackgroundCode.activitiesQueue.Peek());
                    BackgroundCode.seasonframework.SaveChanges();

                    BackgroundCode.activitiesQueue.Dequeue();
                }
            }
        }

        public static void LoadManualMatches()
        {

            string csvBaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string csvProjectBaseDirectory = Path.GetFullPath(Path.Combine(csvBaseDirectory, @"..\..\"));
            string csvPath = Path.Combine(csvProjectBaseDirectory, "ManualMatchList.csv");

            BackgroundCode.manualMatchList = ReadCsvFile(csvPath);
        }
        public static List<List<string>> ReadCsvFile(string filePath)
        {
            var records = new List<List<string>>();

            using (var reader = new StreamReader(filePath))
            {
                string line;
                bool isFirstLine = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }

                    var values = line.Split(',');
                    records.Add(new List<string>(values));
                }
            }

            return records;
        }
        internal static void SaveToRecord(RobotState controller, string recordtype, int controllerNumber)
        {
            bool endMatch = false;
            if (controller.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name && (controller.TransactionCheck || recordtype != "Activities") && controller.TeamName != null)
            {
                if (controller.lastCoralAcqLoc == "Station" && controller.lastTransCoralLoc != "Station")
                {
                    controller.AcqCoralS++;
                }
                else if (controller.lastCoralAcqLoc == "Floor" && controller.lastTransCoralLoc != "Floor")
                {
                    controller.AcqCoralF++;
                }
                if (controller.lastAlgaeAcqLoc == "Reef" && controller.lastTransAlgaeLoc != "Reef")
                {
                    controller.AcqAlgaeR++;
                }
                else if (controller.lastAlgaeAcqLoc == "Floor" && controller.lastTransAlgaeLoc != "Floor")
                {
                    controller.AcqAlgaeF++;
                }

                if (controller.Leave == RobotState.LEAVE.Y && controller.Current_Mode == RobotState.ROBOT_MODE.Auto && recordtype == "EndAuto")
                {
                    controller.PointsScored += 3;
                }
                if (controller.lastAlgaeLoc == "Net")
                {
                    controller.DelAlgaeN++;
                    controller.PointsScored += 4;
                }
                else if (controller.lastAlgaeLoc == "Processor")
                {
                    controller.DelAlgaeP++;
                    controller.PointsScored += 6;
                }
                else if (controller.lastAlgaeLoc == "Floor")
                {
                    controller.DelAlgaeF++;
                }

                if (controller.Current_Mode == RobotState.ROBOT_MODE.Auto)
                {
                    if (controller.lastCoralLoc == "L4")
                    {
                        controller.DelCoralL4++;
                        controller.PointsScored += 7;
                    }
                    else if (controller.lastCoralLoc == "L3")
                    {
                        controller.DelCoralL3++;
                        controller.PointsScored += 6;
                    }
                    else if (controller.lastCoralLoc == "L2")
                    {
                        controller.DelCoralL2++;
                        controller.PointsScored += 4;
                    }
                    else if (controller.lastCoralLoc == "L1")
                    {
                        controller.DelCoralL1++;
                        controller.PointsScored += 3;
                    }
                    else if (controller.lastCoralLoc == "Floor")
                    {
                        controller.DelCoralF++;
                    }
                }
                else
                {
                    if (controller.lastCoralLoc == "L4")
                    {
                        controller.DelCoralL4++;
                        controller.PointsScored += 5;
                    }
                    else if (controller.lastCoralLoc == "L3")
                    {
                        controller.DelCoralL3++;
                        controller.PointsScored += 4;
                    }
                    else if (controller.lastCoralLoc == "L2")
                    {
                        controller.DelCoralL2++;
                        controller.PointsScored += 3;
                    }
                    else if (controller.lastCoralLoc == "L1")
                    {
                        controller.DelCoralL1++;
                        controller.PointsScored += 2;
                    }
                    else if (controller.lastCoralLoc == "Floor")
                    {
                        controller.DelCoralF++;
                    }
                }

                Activity activity_record = BackgroundCode.activity_record[controllerNumber];
                switch (recordtype)
                {
                    case ("EndAuto"):
                        activity_record.Time = DateTime.Now;
                        activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        activity_record.Match = BackgroundCode.currentMatch;
                        activity_record.Mode = controller.Current_Mode.ToString();
                        activity_record.ScouterName = controller.GetScouterName().ToString();


                        activity_record.Match_event = "-";
                        activity_record.Leave = controller.GetLeave().ToString();

                        if (BackgroundCode.redRight)
                        {
                            activity_record.Starting_Loc = controller.GetStart().ToString();
                            activity_record.Del_Near_Far = "-";
                            activity_record.AcqAlgae_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            activity_record.AcqCoral_Near_Far = "Preload";
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }
                        else
                        {
                            activity_record.Starting_Loc = controller.GetStartField().ToString();
                            activity_record.Del_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = !controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = !controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }


                        if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        {
                            activity_record.DriveSta = "red0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        {
                            activity_record.DriveSta = "red1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        {
                            activity_record.DriveSta = "red2";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        {
                            activity_record.DriveSta = "blue0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        {
                            activity_record.DriveSta = "blue1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        {
                            activity_record.DriveSta = "blue2";
                        }

                        controller.DefTimeDouble = controller.DefTime_StopWatch.Elapsed.TotalSeconds;
                        activity_record.DZTime = controller.DefTimeDouble;

                        if (controller.Leave == RobotState.LEAVE.Z)
                        {
                            controller.ScouterError += 1;
                        }
                        if (controller.Starting_Location == RobotState.STARTING_LOC.Select)
                        {
                            controller.ScouterError += 1;
                        }
                        activity_record.ScouterError = controller.ScouterError;

                        activity_record.AcqAlgaeF = controller.AcqAlgaeF;
                        activity_record.AcqAlgaeR = controller.AcqAlgaeR;
                        activity_record.DisAlg = controller.DisAlgae;
                        activity_record.AcqCoralS = controller.AcqCoralS;
                        activity_record.AcqCoralF = controller.AcqCoralF;

                        activity_record.DelAlgaeF = controller.DelAlgaeF;
                        activity_record.DelAlgaeN = controller.DelAlgaeN;
                        activity_record.DelAlgaeP = controller.DelAlgaeP;

                        activity_record.DelCoralF = controller.DelCoralF;
                        activity_record.DelCoralL1 = controller.DelCoralL1;
                        activity_record.DelCoralL2 = controller.DelCoralL2;
                        activity_record.DelCoralL3 = controller.DelCoralL3;
                        activity_record.DelCoralL4 = controller.DelCoralL4;

                        activity_record.CageAttempt = "-";
                        activity_record.EndState = "-";
                        activity_record.ClimbT = 0;

                        activity_record.Strategy = "-";
                        activity_record.Defense = "-";
                        activity_record.DefenseValue = "-";
                        activity_record.Avoidance = "-";

                        activity_record.SelectedCage = "-";
                        activity_record.PointScored = controller.PointsScored.ToString();
                        activity_record.RecordType = recordtype;


                        if (controller.hasCoral == 1 && controller.lastCoralLoc != " ")
                        {
                            controller.totalCoralDeliveries++;
                            controller.hasCoral = 0;
                            controller.lastCoralLoc = " ";
                            controller.lastCoralAcqLoc = " ";
                            controller.prevlastCoralAcqLoc = " ";
                        }
                        if (controller.hasAlgae == 1 && controller.lastAlgaeLoc != " ")
                        {
                            controller.hasAlgae = 0;
                            controller.lastAlgaeLoc = " ";
                            controller.lastAlgaeAcqLoc = " ";
                            controller.prevlastAlgaeAcqLoc = " ";
                        }
                        controller.TransactionCheck = false;
                        break;
                    case ("Activities"):
                        activity_record.Time = DateTime.Now;
                        activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        activity_record.Match = BackgroundCode.currentMatch;
                        activity_record.Mode = controller.Current_Mode.ToString();
                        activity_record.ScouterName = controller.GetScouterName().ToString();

                        activity_record.Match_event = "-";
                        activity_record.Leave = "-";
                        activity_record.Starting_Loc = "-";
                        if (BackgroundCode.redRight)
                        {
                            activity_record.Del_Near_Far = controller.DelNearFar ? "Far" : "Near";
                            activity_record.AcqAlgae_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            activity_record.AcqCoral_Near_Far = "Preload";
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }
                        else
                        {
                            activity_record.AcqAlgae_Near_Far = "-";
                            activity_record.Del_Near_Far = !controller.DelNearFar ? "Far" : "Near";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = !controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            activity_record.AcqCoral_Near_Far = "-";
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = !controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }


                        if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        {
                            activity_record.DriveSta = "red0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        {
                            activity_record.DriveSta = "red1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        {
                            activity_record.DriveSta = "red2";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        {
                            activity_record.DriveSta = "blue0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        {
                            activity_record.DriveSta = "blue1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        {
                            activity_record.DriveSta = "blue2";
                        }

                        controller.DefTimeDouble = controller.DefTime_StopWatch.Elapsed.TotalSeconds;
                        activity_record.DZTime = controller.DefTimeDouble;


                        activity_record.ScouterError = controller.ScouterError;

                        activity_record.AcqAlgaeF = controller.AcqAlgaeF;
                        activity_record.AcqAlgaeR = controller.AcqAlgaeR;
                        activity_record.DisAlg = controller.DisAlgae;
                        activity_record.AcqCoralS = controller.AcqCoralS;
                        activity_record.AcqCoralF = controller.AcqCoralF;

                        activity_record.DelAlgaeF = controller.DelAlgaeF;
                        activity_record.DelAlgaeN = controller.DelAlgaeN;
                        activity_record.DelAlgaeP = controller.DelAlgaeP;

                        activity_record.DelCoralF = controller.DelCoralF;
                        activity_record.DelCoralL1 = controller.DelCoralL1;
                        activity_record.DelCoralL2 = controller.DelCoralL2;
                        activity_record.DelCoralL3 = controller.DelCoralL3;
                        activity_record.DelCoralL4 = controller.DelCoralL4;


                        activity_record.CageAttempt = "-";
                        activity_record.EndState = "-";
                        activity_record.ClimbT = 0;

                        activity_record.Strategy = "-";
                        activity_record.Defense = "-";
                        activity_record.DefenseValue = "-";
                        activity_record.Avoidance = "-";

                        activity_record.SelectedCage = "-";
                        activity_record.PointScored = controller.PointsScored.ToString();
                        activity_record.RecordType = recordtype;



                        if (controller.hasCoral == 1 && controller.lastCoralLoc != " ")
                        {
                            controller.totalCoralDeliveries++;
                            controller.hasCoral = 0;
                            controller.lastCoralAcqLoc = " ";
                            controller.prevlastCoralAcqLoc = " ";
                        }
                        if (controller.hasAlgae == 1 && controller.lastAlgaeLoc != " ")
                        {
                            controller.hasAlgae = 0;
                            controller.lastAlgaeAcqLoc = " ";
                            controller.prevlastAlgaeAcqLoc = " ";
                        }
                        controller.lastTransAlgaeLoc = controller.lastAlgaeAcqLoc;
                        controller.lastTransCoralLoc = controller.lastCoralAcqLoc;
                        controller.lastCoralLoc = " ";
                        controller.lastAlgaeLoc = " ";
                        controller.TransactionCheck = false;
                        break;
                    case ("EndMatch"):
                        activity_record.Time = DateTime.Now;
                        activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        activity_record.Match = BackgroundCode.currentMatch;
                        activity_record.Mode = controller.Current_Mode.ToString();
                        activity_record.ScouterName = controller.GetScouterName().ToString();

                        activity_record.Match_event = "-";
                        activity_record.Leave = "-";
                        activity_record.Starting_Loc = "-";
                        if (BackgroundCode.redRight)
                        {
                            activity_record.Del_Near_Far = "-";
                            activity_record.AcqAlgae_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            activity_record.AcqCoral_Near_Far = "Preload";
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }
                        else
                        {
                            activity_record.AcqAlgae_Near_Far = "-";
                            activity_record.Del_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = !controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            activity_record.AcqCoral_Near_Far = "-";
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = !controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }


                        if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        {
                            activity_record.DriveSta = "red0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        {
                            activity_record.DriveSta = "red1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        {
                            activity_record.DriveSta = "red2";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        {
                            activity_record.DriveSta = "blue0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        {
                            activity_record.DriveSta = "blue1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        {
                            activity_record.DriveSta = "blue2";
                        }

                        controller.DefTimeDouble = controller.DefTime_StopWatch.Elapsed.TotalSeconds;
                        activity_record.DZTime = controller.DefTimeDouble;

                        activity_record.AcqAlgaeF = controller.AcqAlgaeF;
                        activity_record.AcqAlgaeR = controller.AcqAlgaeR;
                        activity_record.DisAlg = controller.DisAlgae;
                        activity_record.AcqCoralS = controller.AcqCoralS;
                        activity_record.AcqCoralF = controller.AcqCoralF;

                        activity_record.DelAlgaeF = controller.DelAlgaeF;
                        activity_record.DelAlgaeN = controller.DelAlgaeN;
                        activity_record.DelAlgaeP = controller.DelAlgaeP;

                        activity_record.DelCoralF = controller.DelCoralF;
                        activity_record.DelCoralL1 = controller.DelCoralL1;
                        activity_record.DelCoralL2 = controller.DelCoralL2;
                        activity_record.DelCoralL3 = controller.DelCoralL3;
                        activity_record.DelCoralL4 = controller.DelCoralL4;

                        if (controller.ClimbTDouble == 0)
                        {
                            activity_record.CageAttempt = "N";
                        }
                        else
                        {
                            activity_record.CageAttempt = "Y";
                        }
                        activity_record.EndState = controller.GetState().ToString();

                        controller.ClimbTDouble = controller.ClimbT_StopWatch.Elapsed.TotalSeconds;
                        activity_record.ClimbT = controller.ClimbTDouble;

                        activity_record.Strategy = controller.GetStrat().ToString();
                        activity_record.DefenseValue = controller.Def_Eff.ToString();
                        activity_record.Defense = controller.Def_Rat.ToString();
                        if (controller.Def_Rat == 0 || controller.Def_Rat == 9)
                        {
                            activity_record.DefenseValue = "0";
                            controller.Def_Eff = 0;
                        }
                        activity_record.Avoidance = controller.Avo_Rat.ToString();


                        if (controller.Def_Rat == 9)
                        {
                            controller.ScouterError += 10;
                        }
                        if (controller.Def_Eff == 9)
                        {
                            controller.ScouterError += 10;
                        }
                        if (controller.Avo_Rat == 9)
                        {
                            controller.ScouterError += 10;
                        }
                        activity_record.ScouterError = controller.ScouterError;

                        activity_record.SelectedCage = controller.Selected_Cage;
                        activity_record.PointScored = controller.PointsScored.ToString();
                        activity_record.RecordType = recordtype;

                        if (controller.hasCoral == 1 && controller.lastCoralLoc != " ")
                        {
                            controller.totalCoralDeliveries++;
                            controller.hasCoral = 0;
                            controller.lastCoralLoc = " ";
                            controller.lastCoralAcqLoc = " ";
                            controller.prevlastCoralAcqLoc = " ";
                        }
                        if (controller.hasAlgae == 1 && controller.lastAlgaeLoc != " ")
                        {
                            controller.hasAlgae = 0;
                            controller.lastAlgaeLoc = " ";
                            controller.lastAlgaeAcqLoc = " ";
                            controller.prevlastAlgaeAcqLoc = " ";
                        }
                        controller.TransactionCheck = false;
                        endMatch = true;
                        break;
                    case ("Match_Event"):
                        activity_record.Time = DateTime.Now;
                        activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        activity_record.Match = BackgroundCode.currentMatch;
                        activity_record.Mode = controller.Current_Mode.ToString();
                        activity_record.ScouterName = controller.GetScouterName().ToString();

                        activity_record.Match_event = controller.Match_event.ToString();
                        activity_record.Leave = "-";
                        activity_record.Starting_Loc = "-";
                        activity_record.Del_Near_Far = "-";
                        activity_record.AcqAlgae_Near_Far = "-";
                        activity_record.AcqCoral_Near_Far = "-";


                        if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        {
                            activity_record.DriveSta = "red0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        {
                            activity_record.DriveSta = "red1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        {
                            activity_record.DriveSta = "red2";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        {
                            activity_record.DriveSta = "blue0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        {
                            activity_record.DriveSta = "blue1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        {
                            activity_record.DriveSta = "blue2";
                        }

                        activity_record.DZTime = '-';


                        activity_record.ScouterError = controller.ScouterError;

                        activity_record.AcqAlgaeF = '-';
                        activity_record.AcqAlgaeR = '-';
                        activity_record.DisAlg = '-';
                        activity_record.AcqCoralS = '-';
                        activity_record.AcqCoralF = '-';

                        activity_record.DelAlgaeF = '-';
                        activity_record.DelAlgaeN = '-';
                        activity_record.DelAlgaeP = '-';

                        activity_record.DelCoralF = '-';
                        activity_record.DelCoralL1 = '-';
                        activity_record.DelCoralL2 = '-';
                        activity_record.DelCoralL3 = '-';
                        activity_record.DelCoralL4 = '-';

                        activity_record.CageAttempt = "-";
                        activity_record.EndState = "-";

                        activity_record.ClimbT = '-';

                        activity_record.Strategy = "-";
                        activity_record.Defense = "-";
                        activity_record.DefenseValue = "-";
                        activity_record.Avoidance = "-";

                        activity_record.SelectedCage = "-";
                        activity_record.PointScored = "-";
                        activity_record.RecordType = recordtype;

                        break;
                    case "Defense":
                        activity_record.Time = DateTime.Now;
                        activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                        activity_record.Match = BackgroundCode.currentMatch;
                        activity_record.Mode = RobotState.ROBOT_MODE.Defense.ToString();
                        activity_record.ScouterName = controller.GetScouterName().ToString();

                        activity_record.Match_event = "-";
                        activity_record.Leave = "-";
                        activity_record.Starting_Loc = "-";
                        if (BackgroundCode.redRight)
                        {
                            activity_record.AcqAlgae_Near_Far = "-";
                            activity_record.Del_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            activity_record.AcqCoral_Near_Far = "-";
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }
                        else
                        {
                            activity_record.AcqAlgae_Near_Far = "-";
                            activity_record.Del_Near_Far = "-";
                            if (controller.lastAlgaeLoc != " ")
                            {
                                activity_record.AcqAlgae_Near_Far = !controller.AcqAlgaeNearFar ? "Far" : "Near";
                            }
                            activity_record.AcqCoral_Near_Far = "Preload";
                            if (controller.lastCoralLoc != " ")
                            {
                                activity_record.AcqCoral_Near_Far = !controller.AcqCoralNearFar ? "Far" : "Near";
                            }
                        }


                        if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[0])
                        {
                            activity_record.DriveSta = "red0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[1])
                        {
                            activity_record.DriveSta = "red1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[2])
                        {
                            activity_record.DriveSta = "red2";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[3])
                        {
                            activity_record.DriveSta = "blue0";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[4])
                        {
                            activity_record.DriveSta = "blue1";
                        }
                        else if (BackgroundCode.Robots[controller.ScouterBox] == BackgroundCode.Robots[5])
                        {
                            activity_record.DriveSta = "blue2";
                        }

                        controller.DefTimeDouble = controller.DefTime_StopWatch.Elapsed.TotalSeconds;
                        activity_record.DZTime = controller.DefTimeDouble;


                        activity_record.ScouterError = controller.ScouterError;

                        activity_record.AcqAlgaeF = controller.AcqAlgaeF;
                        activity_record.AcqAlgaeR = controller.AcqAlgaeR;
                        activity_record.DisAlg = controller.DisAlgae;
                        activity_record.AcqCoralS = controller.AcqCoralS;
                        activity_record.AcqCoralF = controller.AcqCoralF;

                        activity_record.DelAlgaeF = controller.DelAlgaeF;
                        activity_record.DelAlgaeN = controller.DelAlgaeN;
                        activity_record.DelAlgaeP = controller.DelAlgaeP;

                        activity_record.DelCoralF = controller.DelCoralF;
                        activity_record.DelCoralL1 = controller.DelCoralL1;
                        activity_record.DelCoralL2 = controller.DelCoralL2;
                        activity_record.DelCoralL3 = controller.DelCoralL3;
                        activity_record.DelCoralL4 = controller.DelCoralL4;

                        activity_record.CageAttempt = "-";
                        activity_record.EndState = "-";

                        activity_record.ClimbT = '-';

                        activity_record.Strategy = "-";
                        activity_record.Defense = "-";
                        activity_record.DefenseValue = "-";
                        activity_record.Avoidance = "-";

                        activity_record.SelectedCage = "-";
                        activity_record.PointScored = controller.PointsScored.ToString();
                        activity_record.RecordType = recordtype;
                        break;
                    default:
                        MessageBox.Show("Error: Record Type not found");
                        break;
                }

                controller.DisFlag = false;
                Activity activityCopy = new Activity
                {
                    Team = activity_record.Team,
                    Match = activity_record.Match,
                    Time = activity_record.Time,
                    RecordType = activity_record.RecordType,
                    Mode = activity_record.Mode,
                    DriveSta = activity_record.DriveSta,
                    Defense = activity_record.Defense,
                    DefenseValue = activity_record.DefenseValue,
                    Avoidance = activity_record.Avoidance,
                    ScouterName = activity_record.ScouterName,
                    ScouterError = activity_record.ScouterError,
                    Match_event = activity_record.Match_event,
                    Strategy = activity_record.Strategy,
                    Coop = activity_record.Coop,
                    DZTime = activity_record.DZTime,
                    Del_Near_Far = activity_record.Del_Near_Far,
                    AcqAlgae_Near_Far = activity_record.AcqAlgae_Near_Far,
                    AcqCoral_Near_Far = activity_record.AcqCoral_Near_Far,
                    Starting_Loc = activity_record.Starting_Loc,
                    Leave = activity_record.Leave,
                    AcqCoralS = activity_record.AcqCoralS,
                    AcqCoralF = activity_record.AcqCoralF,
                    AcqAlgaeR = activity_record.AcqAlgaeR,
                    AcqAlgaeF = activity_record.AcqAlgaeF,
                    DelCoralL1 = activity_record.DelCoralL1,
                    DelCoralL2 = activity_record.DelCoralL2,
                    DelCoralL3 = activity_record.DelCoralL3,
                    DelCoralL4 = activity_record.DelCoralL4,
                    DelCoralF = activity_record.DelCoralF,
                    DelAlgaeP = activity_record.DelAlgaeP,
                    DelAlgaeN = activity_record.DelAlgaeN,
                    DelAlgaeF = activity_record.DelAlgaeF,
                    ClimbT = activity_record.ClimbT,
                    EndState = activity_record.EndState,
                    CageAttempt = activity_record.CageAttempt,
                    SelectedCage = activity_record.SelectedCage,
                    PointScored = activity_record.PointScored,
                    DisAlg = activity_record.DisAlg
                };
                BackgroundCode.activitiesQueue.Enqueue(activityCopy);

                if (endMatch)
                {
                    SendToDatabase();
                }
            }
        }
        private static void SendToDatabase()
        {
            bool hasConnection = CheckConnection();
            if (hasConnection)
            {
                //Writes to server database
                try
                {
                    BackgroundCode.seasonframework.Database.Connection.ConnectionString = Settings.Default._scoutingdbConnectionStringServer;
                    foreach (Activity activity in BackgroundCode.activitiesQueue)
                    {
                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(activity);
                        BackgroundCode.seasonframework.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    //if no internet access, stops trying to write to server
                }
            }

            BackgroundCode.seasonframework.Database.Connection.ConnectionString = Settings.Default._scoutingdbConnectionString;
            foreach (Activity activity in BackgroundCode.activitiesQueue)
            {
                //Saves to local database for redundancy
                //Save Record to the database
                BackgroundCode.seasonframework.ActivitySet.Add(activity);
                BackgroundCode.seasonframework.SaveChanges();
            }


            BackgroundCode.activitiesQueue.Clear();

            for (int i = 0; i < BackgroundCode.gamePads.Length; i++)
            {
                Controllers.ResetValues(i);
            }

            if (hasConnection)
            {
                SyncDatabases();
            }
        }
        private static bool CheckConnection()
        {
            Console.WriteLine(BackgroundCode.seasonframework.Database.Connection.DataSource);
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://96.236.24.79:3000"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private static void SyncDatabases()
        {
            SeasonContext localDB = new SeasonContext();
            localDB.Database.Connection.ConnectionString = Settings.Default._scoutingdbConnectionString;

            BackgroundCode.seasonframework.Database.Connection.ConnectionString = Settings.Default._scoutingdbConnectionStringServer;

            if (BackgroundCode.seasonframework.Database == localDB.Database)
            {
                return;
            }
            BackgroundCode.seasonframework.ActivitySet.RemoveRange(BackgroundCode.seasonframework.ActivitySet);
            BackgroundCode.seasonframework.ActivitySet.AddRange(localDB.ActivitySet);
            BackgroundCode.seasonframework.SaveChanges();
        }
    }
}