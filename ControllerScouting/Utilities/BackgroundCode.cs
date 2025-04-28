using ControllerScouting.Gamepad;
using System.Collections.Generic;

namespace ControllerScouting.Utilities
{
    internal class BackgroundCode
    {
        public static GamePad[] gamePads;                           //List of all the gamepads connected to the computer
        public static Controllers controllers = new();              //The controller class that handles all the gamepad stuff

        public static RobotState[] Robots = new RobotState[6];      //Contains the state of each Scout's match tracking

        public static List<Match> InMemoryMatchList = [];           //The list of all the matches at the selected event.
        public static List<Match> UnSortedMatchList = [];           //This is just the list of all matches, not yet sorted
        public static List<int> MatchNumbers = [];                  //The list of match numbers for the event selected

        public static List<string> teamlist = [];                   //The list of teams for the event selected

        public static Queue<Activity> activitiesQueue = new();      //The queue of activities to be sent to the database
        public static Activity[] activity_record = new Activity[6]; //The activity record being sent to the database
        public static SeasonContext seasonframework = new();        //The database context

        public static List<string> teamPrio = [];                   //List of teams to prioritize scouting
        public static string homeTeam = "frc842";                   //Your team number
        public static List<string> homePrio = [];                   //List of teams to prioritize based on who you play with next

        public static List<List<string>> manualMatchList = null;    //The list of matches inputed manually
        public static bool redRight = false;                        //Is red alliance on your right?
        public static int currentMatch = 0;                         //The current match number
        public static string loadedEvent = "";                      //The event currently loaded
        public static bool practiceMode = false;                    //Is the scouting system in practice mode?
        public static int practiceTeam = 0;
        public BackgroundCode()
        {

        }
    }
}
