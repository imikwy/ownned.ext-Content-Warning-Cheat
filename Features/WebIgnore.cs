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
    public class WebIgnore
    {
        public void runWebIgnore()
        {
            // Dont run through this loop when everything is off
            if (!Cheat.e_ignoreWebs)
            {
                return;
            }
            foreach (Web web in GameObject.FindObjectsOfType<Web>())
            {
                if (Cheat.e_ignoreWebs)
                {
                    web.wholeBodyFactor = 0f;
                    web.distanceFactor = 0f;
                    web.drag = 0f;
                    web.force = 0f;
                }
            }
        }
    }
}
