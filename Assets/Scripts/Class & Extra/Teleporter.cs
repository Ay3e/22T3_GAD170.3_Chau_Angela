using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AngelaChau
{
    public class Teleporter : MonoBehaviour
    {
        //This cube will TELEPORT when "activiated"
        //TELEPORT means to move the cubes random position on the y axis
        private void OnEnable()
        {
            EventsManager.OnTeleportEvent += Activate;
        }

        private void OnDisable()
        {
            EventsManager.OnTeleportEvent -= Activate;
        }
        private void Activate()
        {
            transform.position = new Vector3(2, Random.Range(0.5f, 4f), 0); 
        }
    }
}

