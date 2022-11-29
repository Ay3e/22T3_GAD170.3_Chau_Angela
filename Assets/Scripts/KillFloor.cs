using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{
    public class KillFloor : MonoBehaviour
    {
        [SerializeField] private Transform characterLocation;
        [SerializeField] private Transform respawn;
        private void OnTriggerEnter(Collider collider)
        {
            characterLocation.transform.position = respawn.transform.position;
        }
    }
}

