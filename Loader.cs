// Some standard includes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
//Melon Loader include
using MelonLoader;
// Unity stuff inlcudes
using UnityEngine;
// for hooking game functions
//using HarmonyLib;

namespace ownned.ext
{
    public class Loader : MelonMod
    {

        // Classes
        Cheat cheat = new Cheat();
        Window window = new Window();

        // OnIngameStart()Function
        public override void OnInitializeMelon() // or "public override void OnInitializeMelon()" for melon mod or plugin
        {
            // Center the window on the screen
            window.windowRect.x = (Screen.width - window.windowRect.width) / 2;
            window.windowRect.y = (Screen.height - window.windowRect.height) / 2;

            MelonLogger.Msg(" [OWNNED.EXT] >> Melon Initialized sucessfully");

            // Harmony has no use rn maybe later idk
            //new HarmonyLib.Harmony("com.ikwy.ownned.ext").PatchAll();
        }

        // OnUpdate() Function, calls every second
        public override void OnUpdate()
        {
            //MelonLogger.Msg("ownned.ext running");
            if (Input.GetKeyDown(KeyCode.Insert)) // Toggle the menu when the Tab key is pressed and for new key sys "if (Keyboard.current.insertKey.wasPressedThisFrame)"
            {
                window.showMenu = !window.showMenu;
                MelonLogger.Msg(" [OWNNED.EXT] >> Pressed Insert key");
            }

            // Cheat stuff shit running in here
            cheat.runCheat();
        }

        public override void OnGUI() // add "public override" to this for melon mod 
        {
            if (window.showMenu) // Only draw the menu when showMenu is true
            {
                window.windowRect = GUI.Window(0, window.windowRect, window.runMainWindow, "ownned.ext"); // Create the window with title "Menu"
            }
        }
    }
}
