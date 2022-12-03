using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{
    public class ShowCoffeeTaskUI : MonoBehaviour
    {
        [SerializeField]private GameObject uiObject;
        private void Start()
        {
            uiObject.SetActive(false);
        }

        private void OnTriggerEnter(Collider player)
        {
            if(player.gameObject.tag == "Player")
            {
                uiObject.SetActive(true);
                Destroy(uiObject, 5f);
                Destroy(gameObject, 5f);
            }
        }
        //When player gets into contact with the gameObject, display text for 5 secs after that destroy text
    }
}

