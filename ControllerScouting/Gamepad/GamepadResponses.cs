using ControllerScouting.Utilities;
using System;
using System.Collections.Generic;

namespace ControllerScouting.Gamepad
{
    partial class Controllers
    {
        public void ReadStick(GamePad gamepad, int controllerNumber)
        {
            RobotState robot = BackgroundCode.Robots[controllerNumber];

            if (!robot.NoSho)
            {
                gamepad.Update();

                // Every mode actions
                var baseRobotActions = new List<(Func<bool> buttonPress, Action action)>
                {
                    (() => gamepad.RTHRight_Press, () => robot.CycleEventName(RobotState.CYCLE_DIRECTION.Up)),
                    (() => gamepad.RTHLeft_Press, () => robot.CycleEventName(RobotState.CYCLE_DIRECTION.Down)),
                    (() => gamepad.R3_Press, () => robot.Transact(controllerNumber)),
                    (() => gamepad.LeftButton_Press, () => robot.CoralDelivery(0)),
                    (() => gamepad.RightButton_Press, () => robot.AlgaeDelivery(0)),
                    (() => gamepad.RightButton_Down, () => robot.AlgaeFlag(gamepad.RightButton_Down))
                };

                List<(Func<bool> buttonPress, Action action)> robotActions = new List<(Func<bool> buttonPress, Action action)>(baseRobotActions);

                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto)
                {
                    robotActions.AddRange(new (Func<bool> buttonPress, Action action)[]
                    {
                        // Scouter Name
                        (() => gamepad.LTHRight_Press && gamepad.BButton_Down, () => robot.ChangeScouterName(RobotState.CYCLE_DIRECTION.Up)),
                        (() => gamepad.LTHLeft_Press && gamepad.BButton_Down, () => robot.ChangeScouterName(RobotState.CYCLE_DIRECTION.Down))
                    });
                }
                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    robotActions.AddRange(new (Func<bool> buttonPress, Action action)[]
                    {
                        // Auto Leave
                        (() => gamepad.BackButton_Press, () => robot.CycleLeave(RobotState.CYCLE_DIRECTION.Up)),

                        // Starting Location
                        (() => gamepad.LTHUp_Press, () => robot.CycleStart(RobotState.CYCLE_DIRECTION.Up)),
                        (() => gamepad.LTHDown_Press, () => robot.CycleStart(RobotState.CYCLE_DIRECTION.Down)),

                        // Leave Auto Mode
                        (() => gamepad.StartButton_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Teleop)),


                        // Near Far Side
                        (() => gamepad.YButton_Press, () => robot.ChangeSide(false)),
                        (() => gamepad.AButton_Press, () => robot.ChangeSide(true)),

                        // Coral Acquire
                        (() => gamepad.LeftButton_Press, () => robot.CoralAcquire(0)),
                        (() => gamepad.LeftTrigger_Press, () => robot.CoralAcquire(1)),

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
                    });
                }
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Teleop && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    robotActions.AddRange(new (Func<bool> buttonPress, Action action)[]
                    {
                        // Leave Teleop Mode
                        (() => gamepad.StartButton_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Surfacing)),
                        (() => gamepad.L3_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Defense)),

                        // Near Far Side
                        (() => gamepad.YButton_Press, () => robot.ChangeSide(false)),
                        (() => gamepad.AButton_Press, () => robot.ChangeSide(true)),

                        // Coral Acquire
                        (() => gamepad.LeftButton_Press, () => robot.CoralAcquire(0)),
                        (() => gamepad.LeftTrigger_Press, () => robot.CoralAcquire(1)),

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
                    });
                }
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Defense && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    robotActions.AddRange(new (Func<bool> buttonPress, Action action)[]
                    {
                        // Leave Defense Mode
                        (() => gamepad.StartButton_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Surfacing)),
                        (() => gamepad.L3_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Teleop)),

                        // Near Far Side
                        (() => gamepad.YButton_Press, () => robot.ChangeSide(false)),
                        (() => gamepad.AButton_Press, () => robot.ChangeSide(true)),

                        // Coral Acquire
                        (() => gamepad.LeftButton_Press, () => robot.CoralAcquire(0)),
                        (() => gamepad.LeftTrigger_Press, () => robot.CoralAcquire(1)),

                        // Algae Acquire
                        (() => gamepad.LeftButton_Press && robot.Flag, () => robot.AlgaeAcquire(0)),
                        (() => gamepad.LeftTrigger_Press && robot.Flag, () => robot.AlgaeAcquire(1)),

                        // Algae Delivery
                        (() => gamepad.DpadUp_Press && robot.Flag, () => robot.AlgaeDelivery(2)),
                        (() => gamepad.DpadDown_Press && robot.Flag, () => robot.AlgaeDelivery(1))
                    });
                }
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Surfacing && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    robotActions.AddRange(new (Func<bool> buttonPress, Action action)[]
                    {
                        // Leave Surfacing Mode
                        (() => gamepad.StartButton_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Teleop)),
                        (() => gamepad.L3_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Defense)),

                        // Timer controls
                        (() => gamepad.BackButton_Press, () => robot.StopTimer()),
                        (() => gamepad.LeftTrigger_Press, () => robot.ResetTimer()),

                        // End game states
                        (() => gamepad.DpadUp_Press, () => robot.CycleState(RobotState.CYCLE_DIRECTION.Up)),
                        (() => gamepad.DpadRight_Press, () => robot.CycleAvoidance()),
                        (() => gamepad.DpadDown_Press, () => robot.CycleEffectiveness()),
                        (() => gamepad.DpadLeft_Press, () => robot.CycleDefense()),

                        (() => gamepad.AButton_Press, () => robot.CycleStrat(RobotState.CYCLE_DIRECTION.Up))
                    });
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
    }
}