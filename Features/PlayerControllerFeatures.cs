using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// For using all other files from this project
using ownned.ext;
using UnityEngine;

namespace ownned.ext
{
    public class PlayerControllerFeatures
    {
        public void runPlayerControllerFeatures()
        {
            // Dont run through this loop when everything is off
            if (!Cheat.e_playerControllerSpeedMultiplier)
            {
                return;
            }
            foreach (PlayerController playerController in GameObject.FindObjectsOfType<PlayerController>())
            {
                // Speed Feature
                if (Cheat.e_playerControllerSpeedMultiplier && Cheat.f_playerControllerSpeedMultiplier != 2.3)
                {
                    playerController.sprintMultiplier = Cheat.f_playerControllerSpeedMultiplier;//2.3f is standart
                }
            }
        }
    }
}
