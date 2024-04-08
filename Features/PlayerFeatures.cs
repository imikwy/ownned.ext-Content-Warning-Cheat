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
    public class PlayerFeatures
    {
        public void runPlayerFeatures()
        {
            // Dont run through this loop when everything is off
            if (!Cheat.e_infiniteHeal || !Cheat.e_infiniteJump || !Cheat.e_infiniteOxygen || !Cheat.e_infiniteStamina || !Cheat.e_godMode)
            {
                return;
            }

            foreach (Player player in GameObject.FindObjectsOfType<Player>())
            {
                if(Cheat.e_infiniteHeal)
                {
                    player.data.health = 100f;
                }
                if(Cheat.e_infiniteJump)
                {
                    player.data.sinceGrounded = 0.4f;
                    player.data.sinceJump = 0.7f;
                }
                if (Cheat.e_infiniteOxygen)
                {
                    player.data.remainingOxygen = 500f;
                }
                if(Cheat.e_infiniteStamina)
                {
                    player.data.currentStamina = 10f;
                }
                if (Cheat.e_godMode)
                {
                    player.data.dead = false;
                }
            }
        }
    }
}
