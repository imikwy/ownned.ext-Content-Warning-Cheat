using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;

// For using all other files from this project
using ownned.ext;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

namespace ownned.ext.Features
{
    public class BatteryFeatures
    {
        public void runBatteryFeatures()
        {
            // Array mit den verschiedenen Gerätetypen erstellen
            var deviceTypes = new[] { typeof(Flashlight), typeof(Defib), typeof(ShockStick), typeof(Flare) };

            if (!Cheat.e_infiniteBatteryEnable)
            {
                return;
            }
            foreach (var deviceType in deviceTypes)
            {
                // Überprüfen, ob das Flag für dieses Gerät gesetzt ist
                bool applyUnlimitedBattery = false;
                if (deviceType == typeof(Flashlight) && Cheat.e_infiniteBatteryFlashlight)
                {
                    applyUnlimitedBattery = true;
                }
                else if (deviceType == typeof(Defib) && Cheat.e_infiniteBatteryDefib)
                {
                    applyUnlimitedBattery = true;
                }
                else if (deviceType == typeof(ShockStick) && Cheat.e_infiniteBatteryShockStick)
                {
                    applyUnlimitedBattery = true;
                }
                else if (deviceType == typeof(Flare) && Cheat.e_infiniteBatteryFlare)
                {
                    applyUnlimitedBattery = true;
                }

                if (applyUnlimitedBattery)
                {
                    // Durch jedes Gerät iterieren und Batterie auf unbegrenzt setzen
                    foreach (var device in GameObject.FindObjectsOfType(deviceType))
                    {
                        FieldInfo batteryEntryField = deviceType.GetField("m_batteryEntry", BindingFlags.NonPublic | BindingFlags.Instance);
                        BatteryEntry batteryEntry = (BatteryEntry)batteryEntryField.GetValue(device);

                        if (batteryEntry != null)
                        {
                            batteryEntry.m_charge = 150f;
                            batteryEntry.m_maxCharge = 150f;
                        }
                    }
                }
            }

            if (Cheat.e_infiniteBatteryVideoCamera)
            {
                // Search for all Camera in the Unity Game Scene!
                VideoCamera[] vidCams = GameObject.FindObjectsOfType<VideoCamera>();

                // Loop through all this camers
                foreach (VideoCamera vidCam in vidCams)
                {
                    // After reversing the VideoCamera Class we see that it creates and contains a new Child Class VideoInfoEntry
                    // named m_recorderInfoEntry with 3 Values videoID;timeLeft;maxTime and we know that we need to get acces to this 
                    // values especially timeLeft
                    FieldInfo field_VideoInfoEntry = vidCam.GetType().GetField("m_recorderInfoEntry", BindingFlags.Instance | BindingFlags.NonPublic);

                    // now we create a object with this child object vidCam and a new entry
                    object value = field_VideoInfoEntry.GetValue(vidCam);
                    FieldInfo field_timeLeft = value.GetType().GetField("timeLeft", BindingFlags.Instance | BindingFlags.Public);

                    field_timeLeft.SetValue(value, 100f);
                }
            }
        }
    }
}
