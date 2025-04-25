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

                // Every mode actions
                var baseRobotActions = new List<(Func<bool> buttonPress, Action action)>
                {
                    (() => gamepad.RTHRight_Press, () => robot.CycleEventName(RobotState.CYCLE_DIRECTION.Up)),
                    (() => gamepad.RTHLeft_Press, () => robot.CycleEventName(RobotState.CYCLE_DIRECTION.Down)),
                    (() => gamepad.RightTrigger_Press, () => robot.Transact(controllerNumber,false)),
                    (() => gamepad.R3_Press, () => robot.Transact(controllerNumber,true)),
                    (() => gamepad.LeftButton_Press, () => robot.CoralDelivery(0)),
                    (() => gamepad.RightButton_Press, () => robot.AlgaeDelivery(0)),
                    (() => gamepad.RightButton_Down, () => robot.AlgaeFlag(true)),
                    (() => gamepad.RightButton_Release, () => robot.AlgaeFlag(false)),
                    (() => gamepad.LeftButton_Press || gamepad.LeftTrigger_Press, () => robot.SetPreviousAcquires(false)),
                    (() => gamepad.RightButton_Release, () => robot.SetPreviousAcquires(true))
            };

                List<(Func<bool> buttonPress, Action action)> robotActions = [.. baseRobotActions];

                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto)
                {
                    robotActions.AddRange(
                    [
                        // Scouter Name
                        (() => gamepad.LTHRight_Press && gamepad.BButton_Down, () => robot.ChangeScouterName(RobotState.CYCLE_DIRECTION.Up)),
                        (() => gamepad.LTHLeft_Press && gamepad.BButton_Down, () => robot.ChangeScouterName(RobotState.CYCLE_DIRECTION.Down))
                    ]);
                }
                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    robotActions.AddRange(
                    [
                        // Auto Leave
                        (() => gamepad.BackButton_Press, () => robot.CycleLeave(RobotState.CYCLE_DIRECTION.Up)),

                        // Starting Location
                        (() => gamepad.LTHUp_Press, () => robot.CycleStart(RobotState.CYCLE_DIRECTION.Up)),
                        (() => gamepad.LTHDown_Press, () => robot.CycleStart(RobotState.CYCLE_DIRECTION.Down)),

                        // Leave Auto Mode
                        (() => gamepad.StartButton_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Teleop,controllerNumber)),


                        // Near Far Side
                        (() => gamepad.YButton_Press, () => robot.ChangeSide(false)),
                        (() => gamepad.AButton_Press, () => robot.ChangeSide(true)),

                        // Coral Acquire
                        (() => gamepad.LeftButton_Press && !robot.Flag, () => robot.CoralAcquire(0)),
                        (() => gamepad.LeftTrigger_Press && !robot.Flag, () => robot.CoralAcquire(1)),

                        // Algae Acquire
                        (() => gamepad.LeftButton_Press && robot.Flag, () => robot.AlgaeAcquire(0)),
                        (() => gamepad.LeftTrigger_Press && robot.Flag, () => robot.AlgaeAcquire(1)),

                        // Coral Delivery
                        (() => gamepad.DpadUp_Press, () => robot.CoralDelivery(4)),
                        (() => gamepad.DpadRight_Press, () => robot.CoralDelivery(3)),
                        (() => gamepad.DpadDown_Press, () => robot.CoralDelivery(2)),
                        (() => gamepad.DpadLeft_Press, () => robot.CoralDelivery(1)),

                        // Algae Delivery
                        (() => gamepad.DpadUp_Press && robot.Flag, () => robot.AlgaeDelivery(2)),
                        (() => gamepad.DpadDown_Press && robot.Flag, () => robot.AlgaeDelivery(1))
                    ]);
                }
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Teleop && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    robotActions.AddRange(
                    [
                        // Leave Teleop Mode
                        (() => gamepad.StartButton_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Surfacing, controllerNumber)),
                        (() => gamepad.L3_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Defense, controllerNumber)),

                        // Near Far Side
                        (() => gamepad.YButton_Press, () => robot.ChangeSide(false)),
                        (() => gamepad.AButton_Press, () => robot.ChangeSide(true)),

                        // Coral Acquire
                        (() => gamepad.LeftButton_Press && !robot.Flag, () => robot.CoralAcquire(0)),
                        (() => gamepad.LeftTrigger_Press && !robot.Flag, () => robot.CoralAcquire(1)),

                        // Algae Acquire
                        (() => gamepad.LeftButton_Press && robot.Flag, () => robot.AlgaeAcquire(0)),
                        (() => gamepad.LeftTrigger_Press && robot.Flag, () => robot.AlgaeAcquire(1)),

                        // Coral Delivery
                        (() => gamepad.DpadUp_Press, () => robot.CoralDelivery(4)),
                        (() => gamepad.DpadRight_Press, () => robot.CoralDelivery(3)),
                        (() => gamepad.DpadDown_Press, () => robot.CoralDelivery(2)),
                        (() => gamepad.DpadLeft_Press, () => robot.CoralDelivery(1)),

                        // Algae Delivery
                        (() => gamepad.DpadUp_Press && robot.Flag, () => robot.AlgaeDelivery(2)),
                        (() => gamepad.DpadDown_Press && robot.Flag, () => robot.AlgaeDelivery(1))
                    ]);
                }
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Defense && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    robotActions.AddRange(
                    [
                        // Leave Defense Mode
                        (() => gamepad.StartButton_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Surfacing, controllerNumber)),
                        (() => gamepad.L3_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Teleop, controllerNumber)),

                        // Near Far Side
                        (() => gamepad.YButton_Press, () => robot.ChangeSide(false)),
                        (() => gamepad.AButton_Press, () => robot.ChangeSide(true)),

                        // Coral Acquire
                        (() => gamepad.LeftButton_Press && ! robot.Flag, () => robot.CoralAcquire(0)),
                        (() => gamepad.LeftTrigger_Press && !robot.Flag, () => robot.CoralAcquire(1)),

                        // Algae Acquire
                        (() => gamepad.LeftButton_Press && robot.Flag, () => robot.AlgaeAcquire(0)),
                        (() => gamepad.LeftTrigger_Press && robot.Flag, () => robot.AlgaeAcquire(1)),

                        // Algae Delivery
                        (() => gamepad.DpadUp_Press && robot.Flag, () => robot.AlgaeDelivery(2)),
                        (() => gamepad.DpadDown_Press && robot.Flag, () => robot.AlgaeDelivery(1))
                    ]);
                }
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Surfacing && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    robotActions.AddRange(
                    [
                        // Leave Surfacing Mode
                        (() => gamepad.StartButton_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Teleop, controllerNumber)),
                        (() => gamepad.L3_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Defense, controllerNumber)),

                        // Timer controls
                        (() => gamepad.BackButton_Press, () => robot.StopTimer()),
                        (() => gamepad.LeftTrigger_Press, () => robot.ResetTimer()),

                        // End game states
                        (() => gamepad.DpadUp_Press, () => robot.CycleState(RobotState.CYCLE_DIRECTION.Up)),
                        (() => gamepad.DpadRight_Press, () => robot.CycleAvoidance()),
                        (() => gamepad.DpadDown_Press, () => robot.CycleEffectiveness()),
                        (() => gamepad.DpadLeft_Press, () => robot.CycleDefense()),

                        (() => gamepad.AButton_Press, () => robot.CycleStrat(RobotState.CYCLE_DIRECTION.Up))
                    ]);
                }

                foreach (var (buttonPress, action) in robotActions)
                {
                    if (buttonPress())
                    {
                        action();
                    }
                }
            }
        }
        public static void ResetValues(int controllerNumber)
        {
            RobotState robot = BackgroundCode.Robots[controllerNumber];
            robot.Current_Mode = RobotState.ROBOT_MODE.Auto;
            robot.Leave = RobotState.LEAVE.Z;
            robot.AUTO = true;
            robot.Starting_Location = RobotState.STARTING_LOC.Select;
            robot.DelNearFar = false;

            robot.AcqAlgaeF = 0;
            robot.AcqAlgaeR = 0;
            robot.DisAlgae = 0;
            robot.AcqCoralS = 0;
            robot.AcqCoralF = 0;
            robot.hasCoral = 0;
            robot.hasAlgae = 0;

            robot.DisAlgae = 0;
            robot.DisFlag = false;

            robot.DelAlgaeF = 0;
            robot.DelAlgaeN = 0;
            robot.DelAlgaeP = 0;

            robot.DelCoralF = 0;
            robot.DelCoralL1 = 0;
            robot.DelCoralL2 = 0;
            robot.DelCoralL3 = 0;
            robot.DelCoralL4 = 0;

            robot.lastAlgaeAcqLoc = " ";
            robot.prevlastAlgaeAcqLoc = " ";
            robot.lastCoralAcqLoc = " ";
            robot.prevlastCoralAcqLoc = " ";

            robot.totalCoralDeliveries = 0;

            robot.Cage_Attempt = RobotState.CAGE_ATTEMPT.Select;
            robot.End_State = RobotState.END_STATE.Select;

            robot.ClimbT_StopWatch ??= new Stopwatch();
            robot.DefTime_StopWatch ??= new Stopwatch();
            try
            {
                robot.ClimbT_StopWatch.Stop();
                robot.ClimbT_StopWatch.Reset();
                robot.ClimbT = TimeSpan.Zero;
                robot.ClimbTDouble = 0;
                robot.ClimbT_StopWatch_running = false;
            }
            catch { }

            try
            {
                robot.DefTime_StopWatch.Stop();
                robot.DefTime_StopWatch.Reset();
                robot.DefTime = TimeSpan.Zero;
                robot.DefTimeDouble = 0;
                robot.DefTime_StopWatch_running = false;
            }
            catch { }

            robot.ScouterError = 0;
            robot.NoSho = false;
            robot.Flag = false;

            robot.Def_Rat = 9;
            robot.Def_Eff = 9;
            robot.Avo_Rat = 9;

            robot.lastCoralLoc = " ";
            robot.lastAlgaeLoc = " ";
            robot.lastCoralAcqLoc = " ";
            robot.lastAlgaeAcqLoc = " ";

            robot.PointsScored = 0;
            robot.App_Strategy = RobotState.APP_STRAT.Select;
        }
    }
}