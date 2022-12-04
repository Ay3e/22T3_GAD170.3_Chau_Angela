using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{
    public class TaskAndInfromUI : MonoBehaviour
    {
        [SerializeField]private GameObject trigger;
        private void Start()
        {
            trigger.SetActive(false);
        }

        private void OnTriggerEnter(Collider player)
        {
            if(player.gameObject.tag == "Player")
            {
                trigger.SetActive(true);
                Destroy(trigger, 5f);
                Destroy(gameObject, 5f);
            }
        }
        //When player gets into contact with the gameObject, display text for 5 secs after that destroy text
    }
}

