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
    public class CustomFov
    {
        public void runCustomFov()
        {
            if (!Cheat.e_customFov)
            {
                return;
            }
            foreach (Camera cam in GameObject.FindObjectsOfType<Camera>())
            {
                cam.fieldOfView = Cheat.f_customFov;
            }
        }
    }
}
