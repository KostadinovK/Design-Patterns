using System;
using CommandPattern.Commands;
using CommandPattern.Models;
using CommandPattern.Models.Contracts;

namespace CommandPattern
{
    public class Program
    {
        public static void Main()
        {
            var light = new Light();
            var stereo = new Stereo();

            var turnLightOn = new LightTurnOnCommand(light);
            var turnLightOff = new LightTurnOffCommand(light);

            var stereoOn = new StereoTurnOnCommand(stereo);
            var stereoOff = new StereoTurnOffCommand(stereo);

            var controller = new RemoteController();
            controller.AddCommand(turnLightOn, turnLightOff);
            controller.AddCommand(stereoOn, stereoOff);

            controller.PressedOnButton(0);
            controller.PressedOffButton(0);
            controller.PressedOnButton(1);
            controller.PressedOffButton(1);

            controller.PressedUndoButton();
        }
    }
}
