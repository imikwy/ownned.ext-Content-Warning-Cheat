using MelonLoader;
using ownned.ext.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ownned.ext
{
    public class Window
    {
        // ---------- WINDOW VARS -----------
        public Rect windowRect = new Rect(0, 0, 550, 400); // Window position and size
        public int tab = 0; // Current tab index
        public Color backgroundColor = Color.grey; // Background color
        public bool showMenu = true; // Whether to show the menu or not

        public void runMainWindow(int windowID) 
        {
            GUILayout.BeginHorizontal();

            // Create toggle buttons for each tab
            GUILayout.BeginVertical(GUILayout.Width(100));
            if (GUILayout.Toggle(tab == 0, "EXPLOITS", "Button", GUILayout.ExpandWidth(true)))
            {
                tab = 0;
            }
            if (GUILayout.Toggle(tab == 1, "STATS", "Button", GUILayout.ExpandWidth(true)))
            {
                tab = 1;
            }
            if (GUILayout.Toggle(tab == 2, "ESP", "Button", GUILayout.ExpandWidth(true)))
            {
                tab = 2;
            }
            if (GUILayout.Toggle(tab == 3, "PLAYER", "Button", GUILayout.ExpandWidth(true)))
            {
                tab = 3;
            }

            GUILayout.EndVertical();

            // Display content for the selected tab

            GUILayout.BeginVertical();


            // Display content for the selected tab
            switch (tab)
            {
                case 0:
                    GUILayout.BeginVertical(GUI.skin.box);
                    {
                        GUILayout.BeginHorizontal();
                        {
                            GUILayout.BeginVertical();
                            {
                                //Linke seite der dunklen box
                                Cheat.e_infiniteHeal = GUILayout.Toggle(Cheat.e_infiniteHeal, "Infinite Heal");
                                Cheat.e_infiniteOxygen = GUILayout.Toggle(Cheat.e_infiniteOxygen, "Infinite Oxygen");
                                Cheat.e_infiniteStamina = GUILayout.Toggle(Cheat.e_infiniteStamina, "Infinite Stamina");
                                Cheat.e_godMode = GUILayout.Toggle(Cheat.e_godMode, "God Mod");
                                Cheat.e_infiniteJump = GUILayout.Toggle(Cheat.e_infiniteJump, "Infinite Jump");
                                Cheat.e_ignoreWebs = GUILayout.Toggle(Cheat.e_ignoreWebs, "Ignore Webs");
                                // Cheat.e_freecam = GUILayout.Toggle(Cheat.e_freecam, "Freecam ( Press F )"); // Nor working because im busy
                                Cheat.e_infiniteBatteryEnable = GUILayout.Toggle(Cheat.e_infiniteBatteryEnable, "Infinite Battery");
                                if (Cheat.e_infiniteBatteryEnable)
                                {
                                    Cheat.e_infiniteBatteryFlashlight = GUILayout.Toggle(Cheat.e_infiniteBatteryFlashlight, "Infinite Flashlight Battery");
                                    Cheat.e_infiniteBatteryDefib = GUILayout.Toggle(Cheat.e_infiniteBatteryDefib, "Infinite Defib Battery");
                                    Cheat.e_infiniteBatteryShockStick = GUILayout.Toggle(Cheat.e_infiniteBatteryShockStick, "Infinite Shockstick Battery");
                                    Cheat.e_infiniteBatteryFlare = GUILayout.Toggle(Cheat.e_infiniteBatteryFlare, "Infinite Flare Battery");
                                    Cheat.e_infiniteBatteryVideoCamera = GUILayout.Toggle(Cheat.e_infiniteBatteryVideoCamera, "Infinite Flare Battery");
                                }
                                Cheat.e_playerControllerSpeedMultiplier = GUILayout.Toggle(Cheat.e_playerControllerSpeedMultiplier, "Speed Enable");
                                GUILayout.Space(2);
                                GUILayout.Label("Custom Speed: " + Cheat.f_playerControllerSpeedMultiplier);
                                Cheat.f_playerControllerSpeedMultiplier = GUILayout.HorizontalSlider(Cheat.f_playerControllerSpeedMultiplier, 2.3f, 10f);
                            }
                            GUILayout.EndVertical();

                            GUILayout.Space(10);

                            GUILayout.BeginVertical();
                            {
                                //rechte seite der dunklen box
                                Cheat.e_customFov = GUILayout.Toggle(Cheat.e_customFov, "FOV Changer");
                                GUILayout.Space(2);
                                GUILayout.Label("Custom FOV: " + Cheat.f_customFov);
                                Cheat.f_customFov = GUILayout.HorizontalSlider(Cheat.f_customFov, 1f, 179f);
                            }
                            GUILayout.EndVertical();
                        }
                        GUILayout.EndHorizontal();
                    }
                    GUILayout.EndVertical();
                    break;
                case 1:
                    // Content for tab 2
                    GUILayout.BeginVertical(GUI.skin.box);
                    {
                        GUILayout.BeginHorizontal();
                        {
                            GUILayout.BeginVertical();
                            {
                                GUILayout.Label("MONEY");
                                if (GUILayout.Button("Add 200"))
                                {
                                    MoneyFeatures.addMoneyModule(200);
                                }

                                if (GUILayout.Button("Add 500"))
                                {
                                    MoneyFeatures.addMoneyModule(500);
                                }

                                if (GUILayout.Button("Add 1000"))
                                {
                                    MoneyFeatures.addMoneyModule(1000);
                                }

                                if (GUILayout.Button("Add 2000"))
                                {
                                    MoneyFeatures.addMoneyModule(2000);
                                }
                            }
                            GUILayout.EndVertical();

                            GUILayout.Space(10);

                            GUILayout.BeginVertical();
                            {

                            }
                            GUILayout.EndVertical();
                        }
                        GUILayout.EndHorizontal();
                    }
                    GUILayout.EndVertical();
                    break;
                case 2:

                    break;
            }

            GUILayout.EndVertical();

            GUILayout.EndHorizontal();
            GUI.DragWindow(); // Allow the user to drag the window around
        }

        public void runFeaturesWindow()
        {

        }

        public void runWatermarkWindow()
        {

        }
    }
}
