using GTA;
using GTA.Native;
using GTA.Math;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Media;

public class Test : Script
{
 // Where you initialize all your variables for use.
 private string modName = "Test";
 private string modCreatorName = "PLACEHOLD";

 private Ped playerPed = Game.Player.Character;
 private Player player = Game.Player;

 // Where you initialize the events or do anything when the mod starts.
 public HandsUpScript()
 {
  UI.Notify(modName + " made by: " + modCreatorName + " using script base");

  Tick += OnTick;
  KeyDown += OnKeyDown;
  KeyUp += OnKeyUp;
 }

 // This is where loops/things are run every frame.
 private void OnTick(object sender, EventArgs e)
 {

 }
 
 // When you press a key down or hold it.
 private void OnKeyDown(object sender, KeyEventArgs e)
 {
    if (e.KeyCode == Keys.Y)
    {
        Ped nearestPed = World.GetNearbyPeds(Game.Player.Character, 7f)[0];
        nearestPed.Task.HandsUp(-1);
    }
    if (e.KeyCode == Keys.L)
    {
        Ped nearestPed = World.GetNearbyPeds(Game.Player.Character, 7f)[0];
        Game.Player.Character.CurrentPedGroup.Add(nearestPed, false);
    }
 }

 // When you press a key up or release it.
 private void OnKeyUp(object sender, KeyEventArgs e)
 {

 }
}
