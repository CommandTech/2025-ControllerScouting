using System;
using System.Diagnostics;

namespace ControllerScouting.Utilities
{
    public class RobotState
    {
        public enum ROBOT_MODE { Auto, Teleop, Defense, Surfacing };
        public enum CYCLE_DIRECTION { Up, Down }
        public enum MATCHEVENT_NAME { Match_Event, GotStuck, BrokeDown, CrossedCenter, LostParts, AdditionalPiece, MultiClimb, NoShow, TippedOver, JammedPiece, WentUnderCages }
        public enum SCOUTER_NAME { Select_Name, Scouter1, Scouter2, Scouter3, Scouter4, Scouter5, Scouter6 }

        // Year to Year ints
        public long ScouterError;
        public long prevScouterError;
        public int ScouterBox;
        public bool TransactionCheck;


        // Year to Year doubles
        public static double Red_Score;
        public static double Blue_Score;

        // Year to Year strings
        public string color;

        // Year to Year bools
        public bool RTHUP_Lock;
        public bool AUTO = true;
        public bool NoSho = false;

        //2025
        public enum STARTING_LOC { Select, C1, C2, C3, Center, C4, C5, C6 };
        public enum STARTING_LOC_FIELD { C6, C5, C4, Center, C3, C2, C1, Select };
        public enum LEAVE { Z, Y, N };
        public enum APP_STRAT { Select, None, Defense, Coral, Algae, Hybrid, Surfacing };
        public enum END_STATE { Select, Elsewhere, Park, Shallow, Deep };
        public enum CAGE_ATTEMPT { Select, Y, N };

        public bool Flag = false;
        //False is near, True is far
        public bool DelNearFar = false;
        public bool AcqAlgaeNearFar = false;
        public bool AcqCoralNearFar = false;
        public bool Near_Far_Field = false;

        public int Def_Rat = 9;
        public int Def_Eff = 9;
        public int Avo_Rat = 9;

        public int hasCoral;
        public int hasAlgae;

        public int AcqCoralS;
        public int AcqCoralF;
        public int AcqAlgaeR;
        public int AcqAlgaeF;
        public int DisAlgae;
        public bool DisFlag;

        public int DelCoralL1;
        public int DelCoralL2;
        public int DelCoralL3;
        public int DelCoralL4;
        public int DelCoralF;

        public int totalCoralDeliveries;

        public int DelAlgaeP;
        public int DelAlgaeN;
        public int DelAlgaeF;

        public string prevlastAlgaeLoc = " ";
        public string prevlastCoralLoc = " ";
        public string lastAlgaeLoc = " ";
        public string lastCoralLoc = " ";
        public string lastTransAlgaeLoc = " ";
        public string lastTransCoralLoc = " ";

        public string prevlastAlgaeAcqLoc = " ";
        public string prevlastCoralAcqLoc = " ";
        public string lastAlgaeAcqLoc = " ";
        public string lastCoralAcqLoc = " ";

        public TimeSpan ClimbT = TimeSpan.Zero;
        public Stopwatch ClimbT_StopWatch;
        public bool ClimbT_StopWatch_running;
        public double ClimbTDouble;

        public TimeSpan DefTime = TimeSpan.Zero;
        public Stopwatch DefTime_StopWatch;
        public bool DefTime_StopWatch_running;
        public double DefTimeDouble;

        public int autoCoralPoints;
        public int PointsScored;

        // These are the standard types...

        public ROBOT_MODE Desired_Mode;         //Desired Mode

        //LOCAL VARIABLES SECTION.  All underscored variables indicate local variables for one controller/scouter

        public SCOUTER_NAME _ScouterName;          //ScouterName
        private string _TeamName;                   //TeamName
        private MATCHEVENT_NAME _match_event;       //Match Event
        private ROBOT_MODE _RobotMode;              //Control

        public ROBOT_MODE Current_Mode
        {
            get { return _RobotMode; }
            set { _RobotMode = value; }
        }

        public String TeamName
        {
            get { return _TeamName; }
            set { _TeamName = value; }
        }
        public MATCHEVENT_NAME Match_event
        {
            get { return _match_event; }
            set { _match_event = value; }
        }

        //public SCOUTER_NAME ScouterName
        //{
        //    get { return _ScouterName; }
        //    set { _ScouterName = value; }
        //}
        public SCOUTER_NAME GetScouterName()
        { return _ScouterName; }


        //Scouter Name
        public void ChangeScouterName(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
                _ScouterName = (SCOUTER_NAME)GetNextEnum<SCOUTER_NAME>(_ScouterName);
            else
            {
                _ScouterName = (SCOUTER_NAME)GetPreviousEnum<SCOUTER_NAME>(_ScouterName);
            }
        }

        //Cycle Event Name
        public void CycleEventName(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _match_event = (MATCHEVENT_NAME)GetNextEnum<MATCHEVENT_NAME>(_match_event);
            }
            else
            {
                _match_event = (MATCHEVENT_NAME)GetPreviousEnum<MATCHEVENT_NAME>(_match_event);
            }
        }

        private Enum GetNextEnum<t>(object currentlySelectedEnum)
        {
            Type enumList = typeof(t);
            if (!enumList.IsEnum)
                throw new InvalidOperationException("Object is not an Enum.");

            Array enums = Enum.GetValues(enumList);
            int index = Array.IndexOf(enums, currentlySelectedEnum);
            index = (index + 1) % enums.Length;
            return (Enum)enums.GetValue(index);
        }

        private Enum GetPreviousEnum<t>(object currentlySelectedEnum)
        {
            Type enumList = typeof(t);
            if (!enumList.IsEnum)
                throw new InvalidOperationException("Object is not an Enum.");

            Array enums = Enum.GetValues(enumList);
            int index = Array.IndexOf(enums, currentlySelectedEnum);
            index = (((index == 0) ? enums.Length : index) - 1);
            return (Enum)enums.GetValue(index);
        }

        //2025
        private LEAVE _Leave;
        private STARTING_LOC _StartLoc;
        private STARTING_LOC_FIELD _StartLocField;
        private APP_STRAT _Strategy;
        private END_STATE _EndState;
        private CAGE_ATTEMPT _CageAttempt;

        //2025
        public LEAVE GetLeave()
        { return _Leave; }
        public STARTING_LOC GetStart()
        { return _StartLoc; }
        public STARTING_LOC_FIELD GetStartField()
        { return _StartLocField; }
        public APP_STRAT GetStrat()
        { return _Strategy; }
        public END_STATE GetState()
        { return _EndState; }
        public CAGE_ATTEMPT GetAttempt()
        { return _CageAttempt; }


        public LEAVE Leave
        {
            get { return _Leave; }
            set { _Leave = value; }
        }
        public STARTING_LOC Starting_Location
        {
            get { return _StartLoc; }
            set { _StartLoc = value; }
        }
        public STARTING_LOC_FIELD Starting_Location_Field
        {
            get { return _StartLocField; }
            set { _StartLocField = value; }
        }
        public CAGE_ATTEMPT Cage_Attempt
        {
            get { return _CageAttempt; }
            set { _CageAttempt = value; }
        }
        public END_STATE End_State
        {
            get { return _EndState; }
            set { _EndState = value; }
        }
        public APP_STRAT App_Strategy
        {
            get { return _Strategy; }
            set { _Strategy = value; }
        }

        //2025 cycles
        public void CycleLeave(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _Leave = (LEAVE)GetNextEnum<LEAVE>(_Leave);
            }
            else
            {
                _Leave = (LEAVE)GetPreviousEnum<LEAVE>(_Leave);
            }
            if (_Leave == LEAVE.Z)
            {
                CycleLeave(CycleDirection);
            }
        }

        public void CycleStart(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _StartLoc = (STARTING_LOC)GetNextEnum<STARTING_LOC>(_StartLoc);
            }
            else
            {
                _StartLoc = (STARTING_LOC)GetPreviousEnum<STARTING_LOC>(_StartLoc);
            }
            if (_StartLoc == STARTING_LOC.Select)
            {
                CycleStart(CycleDirection);
            }
        }
        public void CycleStartField(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _StartLocField = (STARTING_LOC_FIELD)GetNextEnum<STARTING_LOC_FIELD>(_StartLocField);
            }
            else
            {
                _StartLocField = (STARTING_LOC_FIELD)GetPreviousEnum<STARTING_LOC_FIELD>(_StartLocField);
            }
            if (_StartLocField == STARTING_LOC_FIELD.Select)
            {
                CycleStartField(CycleDirection);
            }
        }
        public void CycleStrat(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _Strategy = (APP_STRAT)GetNextEnum<APP_STRAT>(_Strategy);
            }
            else
            {
                _Strategy = (APP_STRAT)GetPreviousEnum<APP_STRAT>(_Strategy);
            }
            if (_Strategy == APP_STRAT.Select)
            {
                CycleStrat(CycleDirection);
            }
        }
        public void CycleState(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _EndState = (END_STATE)GetNextEnum<END_STATE>(_EndState);
            }
            else
            {
                _EndState = (END_STATE)GetPreviousEnum<END_STATE>(_EndState);
            }
            if (_EndState == END_STATE.Select)
            {
                CycleState(CycleDirection);
            }
        }
        public void CycleCage(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _CageAttempt = (CAGE_ATTEMPT)GetNextEnum<CAGE_ATTEMPT>(_CageAttempt);
            }
            else
            {
                _CageAttempt = (CAGE_ATTEMPT)GetPreviousEnum<CAGE_ATTEMPT>(_CageAttempt);
            }
            if (_CageAttempt == CAGE_ATTEMPT.Select)
            {
                CycleCage(CycleDirection);
            }
        }


        public void Transact(int controllerNumber, bool isMatchEevent)
        {
            if (isMatchEevent)
            {
                if (Match_event == MATCHEVENT_NAME.Match_Event)
                {
                    ScouterError += 100000;
                }
                else
                {
                    DatabaseCode.SaveToRecord(this, "Match_Event", controllerNumber);
                    if (Match_event == MATCHEVENT_NAME.NoShow)
                    {
                        NoSho = true;
                    }
                    Match_event = MATCHEVENT_NAME.Match_Event;
                }
            }
            else
            {
                DatabaseCode.SaveToRecord(this, "Activities", controllerNumber);
            }
        }
        public void CoralAcquire(int level)
        {
            switch (level)
            {
                case 0:
                    lastCoralAcqLoc = "Station";
                    break;
                case 1:
                    lastCoralAcqLoc = "Floor";
                    break;
            }
            AcqCoralNearFar = DelNearFar;
            hasCoral++;
            if (hasCoral > 1)
            {
                ScouterError += 100000000;
                hasCoral = 1;
            }
        }
        public void AlgaeAcquire(int level)
        {
            switch (level)
            {
                case 0:
                    lastAlgaeAcqLoc = "Reef";
                    break;
                case 1:
                    lastAlgaeAcqLoc = "Floor";
                    break;
            }
            AcqAlgaeNearFar = DelNearFar;
            hasAlgae++;
            if (hasAlgae > 1)
            {
                ScouterError += 1000000;
                hasAlgae = 1;
            }
        }
        public void CoralDelivery(int level)
        {
            if (!Flag && (lastCoralAcqLoc != " " || totalCoralDeliveries == 0))
            {
                if (totalCoralDeliveries == 0 && hasCoral == 0)
                {
                    hasCoral++;
                }
                switch (level)
                {
                    case 4:
                        lastCoralLoc = "L4";
                        TransactionCheck = true;
                        break;
                    case 3:
                        lastCoralLoc = "L3";
                        TransactionCheck = true;
                        break;
                    case 2:
                        lastCoralLoc = "L2";
                        TransactionCheck = true;
                        break;
                    case 1:
                        lastCoralLoc = "L1";
                        TransactionCheck = true;
                        break;
                    case 0:
                        if (lastCoralAcqLoc == prevlastCoralAcqLoc && lastCoralAcqLoc != " " && !Flag)
                        {
                            if (TransactionCheck && totalCoralDeliveries == 0 && lastCoralLoc == "Floor")
                            {
                                hasCoral++;
                                lastCoralAcqLoc = " ";
                                lastCoralLoc = "Floor";
                                AcqCoralNearFar = false;
                            }
                            else
                            {
                                lastCoralLoc = "Floor";
                                TransactionCheck = true;
                            }
                        }
                        break;
                }
                TransactionCheck = true;
            }
        }
        public void AlgaeDelivery(int level)
        {
            switch (level)
            {
                case 2:
                    lastAlgaeLoc = "Net";
                    TransactionCheck = true;
                    break;
                case 1:
                    lastAlgaeLoc = "Processor";
                    TransactionCheck = true;
                    break;
                case 0:
                    if (lastAlgaeAcqLoc == prevlastAlgaeAcqLoc && lastAlgaeAcqLoc != " ")
                    {
                        lastAlgaeLoc = "Floor";
                        TransactionCheck = true;
                    }
                    break;
            }
            TransactionCheck = true;
        }
        public void AlgaeFlag(bool value)
        {
            Flag = value;
        }
        public void ChangeMode(ROBOT_MODE mode, int controllerNumber)
        {
            if (_RobotMode == ROBOT_MODE.Auto)
            {
                DatabaseCode.SaveToRecord(this, "EndAuto", controllerNumber);
            }
            _RobotMode = mode;

            if (_RobotMode == ROBOT_MODE.Surfacing)
            {
                ClimbT_StopWatch.Start();
                ClimbT_StopWatch_running = true;
                ClimbT = ClimbT_StopWatch.Elapsed;
            }
        }
        public void CycleAvoidance()
        {
            Avo_Rat++;
            if (Avo_Rat > 4)
            {
                Avo_Rat = 0;
            }
        }
        public void CycleDefense()
        {
            Def_Rat++;
            if (Def_Rat > 4)
            {
                Def_Rat = 0;
            }
        }
        public void CycleEffectiveness()
        {
            Def_Eff++;
            if (Def_Eff > 4)
            {
                Def_Eff = 0;
            }
        }
        public void StopTimer()
        {
            if (ClimbT_StopWatch_running)
            {
                ClimbT_StopWatch.Stop();
                ClimbT_StopWatch_running = false;
                ClimbT = ClimbT_StopWatch.Elapsed;
                Cage_Attempt = CAGE_ATTEMPT.Y;
            }
            else
            {
                ClimbT_StopWatch.Start();
                ClimbT_StopWatch_running = true;
                ClimbT = ClimbT_StopWatch.Elapsed;
            }
        }
        public void ResetTimer()
        {
            ClimbT = TimeSpan.Zero;
            ClimbT_StopWatch.Reset();
            ClimbT_StopWatch_running = false;

            Cage_Attempt = CAGE_ATTEMPT.N;
        }
        public void ChangeSide(bool side)
        {
            DelNearFar = side;
        }
        public void SetPreviousAcquires(bool isAlgae)
        {
            if (isAlgae)
            {
                prevlastAlgaeLoc = lastAlgaeLoc;
                prevlastAlgaeAcqLoc = lastAlgaeAcqLoc;
            }
            else
            {
                prevlastCoralLoc = lastCoralLoc;
                prevlastCoralAcqLoc = lastCoralAcqLoc;
            }
        }
    }
}
