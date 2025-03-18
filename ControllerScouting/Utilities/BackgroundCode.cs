using ControllerScouting.Gamepad;
using System.Collections.Generic;

namespace ControllerScouting.Utilities
{
    internal class BackgroundCode
    {
        public static GamePad[] gamePads;                                   //List of all the gamepads connected to the computer
        public static Controllers controllers = new Controllers();          //The controller class that handles all the gamepad stuff

        public static RobotState[] Robots = new RobotState[6];              //Contains the state of each Scout's match tracking

        public static List<Match> InMemoryMatchList = new List<Match>();           //The list of all the matches at the selected event.
        public static List<Match> UnSortedMatchList = new List<Match>();           //This is just the list of all matches, not yet sorted
        public static List<int> MatchNumbers = new List<int>();             //The list of match numbers for the event selected

        public static List<string> teamlist = new List<string>();           //The list of teams for the event selected

        public static Queue<Activity> activitiesQueue = new Queue<Activity>();  //The queue of activities to be sent to the database
        public static Activity[] activity_record = new Activity[6];            //The activity record being sent to the database
        public static SeasonContext seasonframework = new SeasonContext();  //The database context

        public static List<string> teamPrio = new List<string>();           //List of teams to prioritize scouting
        public static string homeTeam = "frc842";                           //Your team number
        public static List<string> homePrio = new List<string>();

        public static List<string> cages = new List<string>();

        public static List<List<string>> manualMatchList = null;
        public static bool redRight = false;
        public static int currentMatch = 0;
        public static string loadedEvent = "";
        public static bool practiceMode = false;
        public static bool practiceChanged = false;
        public static bool wasPractice = false;
        public static int practiceTeam = 0;
        public BackgroundCode()
        {

        }
    }
}
