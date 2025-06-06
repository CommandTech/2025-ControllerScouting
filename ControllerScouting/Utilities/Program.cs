﻿using ControllerScouting.Screens;
using System;
using System.Windows.Forms;

namespace ControllerScouting.Utilities
{
    static class Program
    {
        ///The main entry point for the application.
        [STAThread]
        static void Main()
        {

            //Handles code crashes, used for saving data when the code crashes during events
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Defaults some settings
            //Settings.Default.loadedEvent = null;
            //Settings.Default.manualMatchList = null;
            //Settings.Default.DBExists = false;

            //Determines what functions to run when different exceptions are thrown
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Logger.Erase();
            Application.Run(new BaseScreen());
        }

        // Handle UI thread exceptions
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            HandleException(e.Exception);
        }

        // Handle non-UI thread exceptions
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException(e.ExceptionObject as Exception);
        }

        // Common exception handling method
        static void HandleException(Exception ex)
        {
            if (ex != null)
            {
                // Log the exception, show a message, or perform other actions
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                SaveDataOnCrash();
            }
        }

        // Method to save data or perform cleanup on crash
        static void SaveDataOnCrash()
        {
            try
            {
                //Setting the variables of the config file
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string projectBaseDirectory = System.IO.Path.GetFullPath(System.IO.Path.Combine(baseDirectory, @"..\..\"));
                string iniPath = System.IO.Path.Combine(projectBaseDirectory, "config.ini");
                INIFile iniFile = new(iniPath);

                //Determines if the loaded event is a manual event or a real event
                //Then saves the data to the config file
                if (BackgroundCode.loadedEvent == null)
                {
                    iniFile.Write("MatchData", "event", "manualEvent");
                }
                else
                {
                    iniFile.Write("MatchData", "event", BackgroundCode.loadedEvent);
                }
                iniFile.Write("MatchData", "match_number", BackgroundCode.currentMatch.ToString());
                iniFile.Write("MatchData", "redRight", BackgroundCode.redRight.ToString());
                iniFile.Write("MatchData", "teamPrio", string.Join(",", BackgroundCode.teamPrio));
                iniFile.Write("MatchData", "homeTeam", BackgroundCode.homeTeam);
                //Gets the current scouter names and locations to save
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
                iniFile.Write("MatchData", "scouterNames", scouterNames);
                iniFile.Write("MatchData", "scouterLocations", scouterLocations);

            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the save process
                MessageBox.Show("Error saving data on crash: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Environment.Exit(0);
        }
    }
}