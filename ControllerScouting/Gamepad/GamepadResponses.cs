using ControllerScouting.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ControllerScouting.Gamepad
{
    partial class Controllers
    {
        public void ReadStick(GamePad gamepad, int controllerNumber)
        {
            RobotState robot = BackgroundCode.Robots[controllerNumber];

            if (!robot.NoSho)
            {
                //If the stopwatch does not exist, creates it
                robot.ClimbT_StopWatch ??= new Stopwatch();
                robot.DefTime_StopWatch ??= new Stopwatch();

                gamepad.Update();

                //***********************************
                //CHANGE SCOUTER NAME
                //***********************************
                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto)
                {
                    //Select Scouter Name
                    if (gamepad.BButton_Down && gamepad.LTHRight_Press)
                    {
                        robot.ChangeScouterName(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.BButton_Down && gamepad.LTHLeft_Press)
                    {
                        robot.ChangeScouterName(RobotState.CYCLE_DIRECTION.Down);
                    }
                }
                //***********************************
                //AUTO MODE
                //***********************************
                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    //Cycle Leave
                    if (gamepad.BackButton_Press)
                    {
                        robot.CycleLeave(RobotState.CYCLE_DIRECTION.Up);
                    }

                    //Cycle Starting Location
                    if (gamepad.LTHDown_Press && !gamepad.LeftTrigger_Down)
                    {
                        robot.CycleStart(RobotState.CYCLE_DIRECTION.Down);
                        robot.CycleStartField(RobotState.CYCLE_DIRECTION.Down);
                        if (robot.Starting_Location == RobotState.STARTING_LOC.C1 || robot.Starting_Location == RobotState.STARTING_LOC.C2 || robot.Starting_Location == RobotState.STARTING_LOC.C3)
                        {
                            robot.DelNearFar = false;
                        }
                        else
                        {
                            robot.DelNearFar = true;
                        }
                    }
                    else if (gamepad.LTHUp_Press && !gamepad.LeftTrigger_Down)
                    {
                        robot.CycleStart(RobotState.CYCLE_DIRECTION.Up);
                        robot.CycleStartField(RobotState.CYCLE_DIRECTION.Up);
                        if (robot.Starting_Location == RobotState.STARTING_LOC.C1 || robot.Starting_Location == RobotState.STARTING_LOC.C2 || robot.Starting_Location == RobotState.STARTING_LOC.C3)
                        {
                            robot.DelNearFar = false;
                        }
                        else
                        {
                            robot.DelNearFar = true;
                        }
                    }

                    //Acquire Coral/Algae from Station/Reef
                    if (gamepad.LeftButton_Press)
                    {
                        if (robot.Flag && robot.lastAlgaeAcqLoc != "Reef")
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Reef";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else if (robot.Flag && robot.lastAlgaeAcqLoc == "Reef")
                        {
                            robot.hasAlgae--;
                            robot.lastAlgaeAcqLoc = " ";
                            robot.DisAlgae++;
                            robot.lastAlgaeLoc = " ";
                            robot.TransactionCheck = false;
                            robot.DisFlag = true;
                        }
                        else if (robot.lastCoralAcqLoc == " ")
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Station";
                            robot.AcqCoralNearFar = robot.DelNearFar;
                        }
                    }
                    //Acquire Coral/Algae from Floor
                    if (gamepad.LeftTrigger_Press)
                    {
                        if (robot.Flag && robot.lastAlgaeAcqLoc == " ")
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Floor";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else if (robot.lastCoralAcqLoc == " ")
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Floor";
                            robot.AcqCoralNearFar = robot.DelNearFar;
                        }
                    }

                    //Deliveries
                    if (gamepad.RightButton_Press && robot.lastAlgaeAcqLoc == robot.prevlastAlgaeAcqLoc && robot.lastAlgaeAcqLoc != " ")
                    {
                        robot.lastAlgaeLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    if (gamepad.LeftButton_Press && robot.lastCoralAcqLoc == robot.prevlastCoralAcqLoc && robot.lastCoralAcqLoc != " " && !robot.Flag)
                    {
                        if (robot.TransactionCheck && robot.totalCoralDeliveries == 0 && robot.lastCoralLoc == "Floor")
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = " ";
                            robot.lastCoralLoc = "Floor";
                            robot.AcqCoralNearFar = false;
                        }
                        else
                        {
                            robot.lastCoralLoc = "Floor";
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadUp_Press)
                    {
                        if (robot.Flag && robot.lastAlgaeAcqLoc != " ")
                        {
                            robot.lastAlgaeLoc = "Net";
                            robot.TransactionCheck = true;
                        }
                        else if (!robot.Flag && (robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0))
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.lastCoralLoc = "L4";
                            robot.autoCoralPoints += 7;
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadDown_Press)
                    {
                        if (robot.Flag && robot.lastAlgaeAcqLoc != " ")
                        {
                            robot.lastAlgaeLoc = "Processor";
                            robot.TransactionCheck = true;
                        }
                        else if (robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0)
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.lastCoralLoc = "L2";
                            robot.autoCoralPoints += 4;
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadRight_Press)
                    {
                        if (!robot.Flag && robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0)
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.lastCoralLoc = "L3";
                            robot.autoCoralPoints += 6;
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadLeft_Press)
                    {
                        if (!robot.Flag && robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0)
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.lastCoralLoc = "L1";
                            robot.autoCoralPoints += 3;
                            robot.TransactionCheck = true;
                        }
                    }

                    if (gamepad.YButton_Press)
                    {
                        robot.DelNearFar = true;
                    }
                    if (gamepad.AButton_Press)
                    {
                        robot.DelNearFar = false;
                    }
                }
                //***********************************
                //TELEOP MODE
                //***********************************
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Teleop && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    //Acquire Coral/Algae from Station/Reef
                    if (gamepad.LeftButton_Press)
                    {
                        if (robot.Flag && robot.lastAlgaeAcqLoc != "Reef")
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Reef";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else if (robot.Flag && robot.lastAlgaeAcqLoc == "Reef")
                        {
                            robot.hasAlgae--;
                            robot.lastAlgaeAcqLoc = " ";
                            robot.DisAlgae++;
                            robot.lastAlgaeLoc = " ";
                            robot.TransactionCheck = false;
                            robot.DisFlag = true;
                        }
                        else if (robot.lastCoralAcqLoc == " ")
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Station";
                            robot.AcqCoralNearFar = robot.DelNearFar;
                        }
                    }
                    //Acquire Coral/Algae from Floor
                    if (gamepad.LeftTrigger_Press)
                    {
                        if (robot.Flag && robot.lastAlgaeAcqLoc == " ")
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Floor";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else if (robot.lastCoralAcqLoc == " ")
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Floor";
                            robot.AcqCoralNearFar = robot.DelNearFar;
                        }
                    }

                    //Deliveries
                    if (gamepad.RightButton_Press && robot.lastAlgaeAcqLoc == robot.prevlastAlgaeAcqLoc && robot.lastAlgaeAcqLoc != " ")
                    {
                        robot.lastAlgaeLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    if (gamepad.LeftButton_Press && robot.lastCoralAcqLoc == robot.prevlastCoralAcqLoc && robot.lastCoralAcqLoc != " " && !robot.Flag)
                    {
                        if (robot.TransactionCheck && robot.totalCoralDeliveries == 0 && robot.lastCoralLoc == "Floor")
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = " ";
                            robot.lastCoralLoc = "Floor";
                            robot.AcqCoralNearFar = false;
                        }
                        else
                        {
                            robot.lastCoralLoc = "Floor";
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadUp_Press)
                    {
                        if (robot.Flag && robot.lastAlgaeAcqLoc != " ")
                        {
                            robot.lastAlgaeLoc = "Net";
                            robot.TransactionCheck = true;
                        }
                        else if (robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0)
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.lastCoralLoc = "L4";
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadDown_Press)
                    {
                        if (robot.Flag && robot.lastAlgaeAcqLoc != " ")
                        {
                            robot.lastAlgaeLoc = "Processor";
                            robot.TransactionCheck = true;
                        }
                        else if (robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0)
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.lastCoralLoc = "L2";
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadRight_Press)
                    {
                        if (!robot.Flag && robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0)
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.lastCoralLoc = "L3";
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadLeft_Press)
                    {
                        if (!robot.Flag && robot.lastCoralAcqLoc != " " || robot.totalCoralDeliveries == 0)
                        {
                            if (robot.totalCoralDeliveries == 0 && robot.hasCoral == 0)
                            {
                                robot.hasCoral++;
                            }
                            robot.lastCoralLoc = "L1";
                            robot.TransactionCheck = true;
                        }
                    }

                    if (gamepad.YButton_Press)
                    {
                        robot.DelNearFar = true;
                    }
                    if (gamepad.AButton_Press)
                    {
                        robot.DelNearFar = false;
                    }
                }
                //***********************************
                //DEFENSE MODE
                //***********************************
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Defense && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    //Acquire Coral/Algae from Station/Reef
                    if (gamepad.LeftButton_Press)
                    {
                        if (robot.Flag && robot.lastAlgaeAcqLoc != "Reef")
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Reef";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else if (robot.Flag && robot.lastAlgaeAcqLoc == "Reef")
                        {
                            robot.hasAlgae--;
                            robot.lastAlgaeAcqLoc = " ";
                            robot.DisAlgae++;
                            robot.lastAlgaeLoc = " ";
                            robot.TransactionCheck = false;
                            robot.DisFlag = true;
                        }
                        else if (robot.lastCoralAcqLoc == " ")
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Station";
                            robot.AcqCoralNearFar = robot.DelNearFar;
                        }
                    }
                    //Acquire Coral/Algae from Floor
                    if (gamepad.LeftTrigger_Press)
                    {
                        if (robot.Flag && robot.lastAlgaeAcqLoc == " ")
                        {
                            robot.hasAlgae++;
                            robot.lastAlgaeAcqLoc = "Floor";
                            robot.AcqAlgaeNearFar = robot.DelNearFar;
                        }
                        else if (robot.lastAlgaeAcqLoc == " ")
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = "Floor";
                            robot.AcqCoralNearFar = robot.DelNearFar;
                        }
                    }

                    //Deliveries
                    if (gamepad.RightButton_Press && robot.lastAlgaeAcqLoc == robot.prevlastAlgaeAcqLoc && robot.lastAlgaeAcqLoc != " ")
                    {
                        robot.lastAlgaeLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    if (gamepad.LeftButton_Press && robot.lastCoralAcqLoc == robot.prevlastCoralAcqLoc && robot.lastCoralAcqLoc != " " && !robot.Flag)
                    {
                        if (robot.TransactionCheck && robot.totalCoralDeliveries == 0 && robot.lastCoralLoc == "Floor")
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = " ";
                            robot.lastCoralLoc = "Floor";
                            robot.AcqCoralNearFar = false;
                        }
                        else
                        {
                            robot.lastCoralLoc = "Floor";
                            robot.TransactionCheck = true;
                        }
                    }
                    if (gamepad.DpadUp_Press)
                    {
                        if (robot.Flag)
                        {
                            if (robot.lastAlgaeAcqLoc != " ")
                            {
                                robot.lastAlgaeLoc = "Net";
                                robot.TransactionCheck = true;
                            }
                        }
                    }
                    if (gamepad.DpadDown_Press)
                    {
                        if (robot.Flag)
                        {
                            if (robot.lastAlgaeAcqLoc != " ")
                            {
                                robot.lastAlgaeLoc = "Processor";
                                robot.TransactionCheck = true;
                            }
                        }
                    }
                    if (gamepad.YButton_Press)
                    {
                        robot.DelNearFar = true;
                    }
                    if (gamepad.AButton_Press)
                    {
                        robot.DelNearFar = false;
                    }
                }
                //***********************************
                //SURFACING MODE
                //***********************************
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Surfacing && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    if (gamepad.RightButton_Press && robot.lastAlgaeAcqLoc == robot.prevlastAlgaeAcqLoc && robot.lastAlgaeAcqLoc != " ")
                    {
                        robot.lastAlgaeLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    if (gamepad.LeftButton_Press && robot.lastCoralAcqLoc == robot.prevlastCoralAcqLoc && robot.lastCoralAcqLoc != " " && !robot.Flag)
                    {
                        if (robot.TransactionCheck && robot.totalCoralDeliveries == 0 && robot.lastCoralLoc == "Floor")
                        {
                            robot.hasCoral++;
                            robot.lastCoralAcqLoc = " ";
                            robot.lastCoralLoc = "Floor";
                            robot.AcqCoralNearFar = false;
                        }
                        else
                        {
                            robot.lastCoralLoc = "Floor";
                            robot.TransactionCheck = true;
                        }
                    }

                    //Stop / Resume Climb Time
                    if (gamepad.BackButton_Press)
                    {
                        if (robot.ClimbT_StopWatch_running)
                        {
                            robot.ClimbT_StopWatch.Stop();
                            robot.ClimbT_StopWatch_running = false;
                            robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                            robot.Cage_Attempt = RobotState.CAGE_ATTEMPT.Y;
                        }
                        else
                        {
                            robot.ClimbT_StopWatch.Start();
                            robot.ClimbT_StopWatch_running = true;
                            robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                        }
                    }
                    //Reset Climb Time
                    if (gamepad.LeftTrigger_Press)
                    {
                        robot.ClimbT = TimeSpan.Zero;
                        robot.ClimbT_StopWatch.Reset();
                        robot.ClimbT_StopWatch_running = false;

                        robot.Cage_Attempt = RobotState.CAGE_ATTEMPT.N;
                    }

                    //Cycle Robot Strat
                    if (gamepad.AButton_Press)
                    {
                        robot.CycleStrat(RobotState.CYCLE_DIRECTION.Up);
                    }
                    //Deliver Algae to the Floor
                    if (gamepad.RightButton_Press && robot.lastAlgaeAcqLoc == robot.prevlastAlgaeAcqLoc && robot.lastAlgaeAcqLoc != " ")
                    {
                        robot.lastAlgaeLoc = "Floor";
                        robot.TransactionCheck = true;
                    }
                    //Deliver Coral to the Floor
                    if (gamepad.LeftButton_Press && robot.totalCoralDeliveries == 0 && !robot.Flag)
                    {
                        robot.hasCoral++;
                        robot.lastCoralLoc = "Floor";
                        robot.TransactionCheck = true;
                    }

                    //Cycle End State
                    if (gamepad.DpadUp_Press)
                    {
                        if (robot.End_State == RobotState.END_STATE.Deep)
                        {
                            robot.PointsScored -= 12;
                        }

                        robot.CycleState(RobotState.CYCLE_DIRECTION.Up);

                        //Totaling end game
                        if (robot.End_State == RobotState.END_STATE.Park)
                        {
                            robot.PointsScored += 2;
                        }
                        else if (robot.End_State == RobotState.END_STATE.Shallow)
                        {
                            robot.PointsScored -= 2;
                            robot.PointsScored += 6;
                        }
                        else if (robot.End_State == RobotState.END_STATE.Deep)
                        {
                            robot.PointsScored -= 6;
                            robot.PointsScored += 12;
                        }
                    }
                    if (gamepad.DpadRight_Press)
                    {
                        //Cycle Avoidance Rating
                        robot.Avo_Rat++;
                        if (robot.Avo_Rat > 4)
                        {
                            robot.Avo_Rat = 0;
                        }
                    }
                    if (gamepad.DpadLeft_Press)
                    {
                        //Cycle Defense Rating
                        robot.Def_Rat++;
                        if (robot.Def_Rat > 4)
                        {
                            robot.Def_Rat = 0;
                        }
                    }
                    if (gamepad.DpadDown_Press)
                    {
                        //Cycle Defense Effectiveness
                        if (robot.Def_Rat != 9 && robot.Def_Rat != 0)
                        {
                            robot.Def_Eff++;
                            if (robot.Def_Eff > 5)
                            {
                                robot.Def_Eff = 0;
                            }
                        }
                        else
                        {
                            robot.Def_Eff = 0;
                        }
                    }
                }

                //***********************************
                //Any mode
                //***********************************
                if (robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    // Changing modes
                    //Leaving Auto
                    if (gamepad.StartButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Auto)
                    {
                        robot.AUTO = false;
                        DatabaseCode.SaveToRecord(robot, "EndAuto", controllerNumber);
                        robot.Desired_Mode = RobotState.ROBOT_MODE.Surfacing;
                        robot.Current_Mode = RobotState.ROBOT_MODE.Teleop;
                    }
                    //Leaving Teleop into Surfacing
                    else if (gamepad.StartButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Teleop)

                    {
                        robot.Desired_Mode = RobotState.ROBOT_MODE.Teleop;
                        robot.Current_Mode = RobotState.ROBOT_MODE.Surfacing;

                        robot.ClimbT_StopWatch.Start();
                        robot.ClimbT_StopWatch_running = true;
                        robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                    }
                    //Leaving Surfacing into Teleop
                    else if (gamepad.StartButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Surfacing)
                    {
                        robot.Desired_Mode = RobotState.ROBOT_MODE.Surfacing;
                        robot.Current_Mode = RobotState.ROBOT_MODE.Teleop;

                        robot.ClimbT_StopWatch.Stop();
                        robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                        robot.ClimbT_StopWatch_running = false;
                        robot.ClimbT_StopWatch.Reset();
                    }
                    //Leaving Defense into Surfacing
                    else if (gamepad.StartButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Defense)
                    {
                        robot.Current_Mode = RobotState.ROBOT_MODE.Surfacing;
                        robot.Desired_Mode = RobotState.ROBOT_MODE.Defense;

                        DatabaseCode.SaveToRecord(robot, "Defense", controllerNumber);

                        robot.DefTime_StopWatch.Reset();

                        robot.ClimbT_StopWatch.Start();
                        robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                        robot.ClimbT_StopWatch_running = true;
                    }
                    else if (gamepad.L3_Press && robot.Current_Mode != RobotState.ROBOT_MODE.Auto)
                    {
                        //Leaving previous mode into Defense
                        if (robot.Current_Mode != RobotState.ROBOT_MODE.Defense)
                        {
                            robot.Desired_Mode = RobotState.ROBOT_MODE.Teleop;
                            robot.Current_Mode = RobotState.ROBOT_MODE.Defense;

                            robot.ClimbT_StopWatch.Stop();
                            robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                            robot.ClimbT_StopWatch_running = false;
                            robot.ClimbT_StopWatch.Reset();

                            robot.DefTime_StopWatch.Start();
                            robot.DefTime = robot.DefTime_StopWatch.Elapsed;
                            robot.DefTime_StopWatch_running = true;
                        }
                        else
                        {
                            robot.Current_Mode = RobotState.ROBOT_MODE.Teleop;
                            robot.Desired_Mode = RobotState.ROBOT_MODE.Defense;

                            robot.DefTime_StopWatch.Stop();
                            robot.DefTime = robot.DefTime_StopWatch.Elapsed;
                            robot.DefTime_StopWatch_running = false;

                            DatabaseCode.SaveToRecord(robot, "Defense", controllerNumber);

                            robot.DefTime_StopWatch.Reset();
                        }
                    }

                    //Algae Flag
                    if (gamepad.RightButton_Down)
                    {
                        robot.Flag = true;
                    }
                    else
                    {
                        robot.Flag = false;
                    }

                    if (gamepad.RightButton_Release)
                    {
                        robot.prevlastAlgaeLoc = robot.lastAlgaeLoc;
                        robot.prevlastAlgaeAcqLoc = robot.lastAlgaeAcqLoc;
                    }
                    if (gamepad.LeftButton_Press || gamepad.LeftTrigger_Press)
                    {
                        robot.prevlastCoralLoc = robot.lastCoralLoc;
                        robot.prevlastCoralAcqLoc = robot.lastCoralAcqLoc;
                    }

                    //Correcting Errors
                    if (robot.hasCoral > 1)
                    {
                        robot.ScouterError += 100000000;
                        robot.hasCoral = 1;
                    }
                    else if (robot.hasCoral < 0)
                    {
                        robot.ScouterError += 10000;
                        robot.hasCoral = 0;
                    }
                    if (robot.hasAlgae > 1)
                    {
                        robot.ScouterError += 1000000;
                        robot.hasAlgae = 1;
                    }
                    else if (robot.hasAlgae < 0)
                    {
                        robot.ScouterError += 100;
                        robot.hasAlgae = 0;
                    }

                    //Match Events
                    if (gamepad.RTHRight_Press)
                    {
                        robot.CycleEventName(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.RTHLeft_Press)
                    {
                        robot.CycleEventName(RobotState.CYCLE_DIRECTION.Down);
                    }

                    //2025 Transaction
                    if (gamepad.RightTrigger_Press && robot.TransactionCheck)
                    {
                        DatabaseCode.SaveToRecord(robot, "Activities", controllerNumber);
                    }
                    else if (gamepad.RightTrigger_Press)
                    {
                        robot.ScouterError += 10000000000;
                    }
                }
            }

            // Values if robot is NoSho
            else if (robot.NoSho)
            {

            }
        }
    }
}