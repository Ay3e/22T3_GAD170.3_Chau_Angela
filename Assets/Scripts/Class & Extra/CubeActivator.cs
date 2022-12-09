using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau {
    public class CubeActivator : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                EventsManager.OnTeleportEvent?.Invoke();
                EventsManager.OnChangeColourEvent?.Invoke();
            }
        }
    }
}

