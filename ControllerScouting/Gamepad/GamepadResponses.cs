using ControllerScouting.Utilities;
using System;
using System.Linq;

namespace ControllerScouting.Gamepad
{
    partial class Controllers
    {
        public void ReadStick(GamePad[] gpArray, int controllerNumber)
        {
            GamePad gamepad = gpArray[controllerNumber];

            RobotState robot = BackgroundCode.Robots[controllerNumber];

            if (gamepad != null && !robot.NoSho)
            {
                gamepad.Update();

                //Every mode actions
                var robotActions = new (Func<bool> buttonPress, Action action)[]{
                    (() => gamepad.RTHRight_Press, () => robot.CycleEventName(RobotState.CYCLE_DIRECTION.Up)),
                    (() => gamepad.RTHLeft_Press, () => robot.CycleEventName(RobotState.CYCLE_DIRECTION.Down)),
                    (() => gamepad.R3_Press, () => robot.Transact(controllerNumber)),
                    (() => gamepad.LeftButton_Press, () => robot.CoralDelivery(0)),
                    (() => gamepad.RightButton_Press, () => robot.AlgaeDelivery(0)),
                    (() => gamepad.RightButton_Down, () => robot.AlgaeFlag(gamepad.RightButton_Down))
                };

                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto)
                {
                    //Auto Leave
                    robotActions.Append((() => gamepad.BackButton_Press, () => robot.CycleLeave(RobotState.CYCLE_DIRECTION.Up)));

                    //Starting Location
                    robotActions.Append((() => gamepad.LTHUp_Press, () => robot.CycleStart(RobotState.CYCLE_DIRECTION.Up)));
                    robotActions.Append((() => gamepad.LTHDown_Press, () => robot.CycleStart(RobotState.CYCLE_DIRECTION.Down)));

                    //Leave Auto Mode
                    robotActions.Append((() => gamepad.StartButton_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Teleop)));

                    //Scouter Name
                    robotActions.Append((() => gamepad.LTHRight_Press && gamepad.BButton_Down, () => robot.ChangeScouterName(RobotState.CYCLE_DIRECTION.Up)));
                    robotActions.Append((() => gamepad.LTHLeft_Press && gamepad.BButton_Down, () => robot.ChangeScouterName(RobotState.CYCLE_DIRECTION.Down)));

                    //Near Far Side
                    robotActions.Append((() => gamepad.YButton_Press, () => robot.ChangeSide(false)));
                    robotActions.Append((() => gamepad.AButton_Press, () => robot.ChangeSide(true)));

                    //Coral Delivery
                    robotActions.Append((() => gamepad.DpadUp_Press, () => robot.CoralDelivery(4)));
                    robotActions.Append((() => gamepad.DpadRight_Press, () => robot.CoralDelivery(3)));
                    robotActions.Append((() => gamepad.DpadDown_Press, () => robot.CoralDelivery(2)));
                    robotActions.Append((() => gamepad.DpadLeft_Press, () => robot.CoralDelivery(1)));

                    //Algae Delivery
                    robotActions.Append((() => gamepad.DpadUp_Press && robot.Flag, () => robot.AlgaeDelivery(2)));
                    robotActions.Append((() => gamepad.DpadDown_Press && robot.Flag, () => robot.AlgaeDelivery(1)));
                }
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Teleop)
                {
                    //Leave Teleop Mode
                    robotActions.Append((() => gamepad.StartButton_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Surfacing)));
                    robotActions.Append((() => gamepad.L3_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Defense)));

                    //Coral Delivery
                    robotActions.Append((() => gamepad.DpadUp_Press, () => robot.CoralDelivery(4)));
                    robotActions.Append((() => gamepad.DpadRight_Press, () => robot.CoralDelivery(3)));
                    robotActions.Append((() => gamepad.DpadDown_Press, () => robot.CoralDelivery(2)));
                    robotActions.Append((() => gamepad.DpadLeft_Press, () => robot.CoralDelivery(1)));

                    //Algae Delivery
                    robotActions.Append((() => gamepad.DpadUp_Press && robot.Flag, () => robot.AlgaeDelivery(2)));
                    robotActions.Append((() => gamepad.DpadDown_Press && robot.Flag, () => robot.AlgaeDelivery(1)));
                }
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Defense)
                {
                    //Leave Defense Mode
                    robotActions.Append((() => gamepad.StartButton_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Surfacing)));
                    robotActions.Append((() => gamepad.L3_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Teleop)));

                    //Algae Delivery
                    robotActions.Append((() => gamepad.DpadUp_Press && robot.Flag, () => robot.AlgaeDelivery(2)));
                    robotActions.Append((() => gamepad.DpadDown_Press && robot.Flag, () => robot.AlgaeDelivery(1)));
                }
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Surfacing)
                {
                    //Leave Surfacing Mode
                    robotActions.Append((() => gamepad.StartButton_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Teleop)));
                    robotActions.Append((() => gamepad.L3_Press, () => robot.ChangeMode(RobotState.ROBOT_MODE.Defense)));

                    //Timer controls
                    robotActions.Append((() => gamepad.BackButton_Press, () => robot.StopTimer()));
                    robotActions.Append((() => gamepad.LeftTrigger_Press, () => robot.ResetTimer()));

                    //End game states
                    robotActions.Append((() => gamepad.DpadUp_Press, () => robot.CycleState(RobotState.CYCLE_DIRECTION.Up)));
                    robotActions.Append((() => gamepad.DpadRight_Press, () => robot.CycleAvoidance()));
                    robotActions.Append((() => gamepad.DpadDown_Press, () => robot.CycleEffectiveness()));
                    robotActions.Append((() => gamepad.DpadLeft_Press, () => robot.CycleDefense()));

                    robotActions.Append((() => gamepad.AButton_Press, () => robot.CycleStrat(RobotState.CYCLE_DIRECTION.Up)));
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