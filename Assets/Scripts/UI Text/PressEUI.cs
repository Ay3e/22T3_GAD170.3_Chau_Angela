using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{
    public class PressEUI : MonoBehaviour
    {
        [SerializeField] private GameObject trigger;

        private void Start()
        {
            trigger.SetActive(false);
        }

        private void OnTriggerEnter(Collider player)
        {
            if (player.gameObject.tag == "Player")
            {
                trigger.SetActive(true);
            }
        }

        private void OnTriggerExit(Collider player)
        {
            if(player.gameObject.tag == "Player")
            {
                trigger.SetActive(false);
            }
        }
        //When player gets into contact with the gameObject, display text for 5 secs after that destroy text
    }
}


