using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{
    public class TransientFloorTrigger : MonoBehaviour
    {
        [SerializeField] private GameObject text;
        [SerializeField] private GameObject trigger;
        [SerializeField] private GameObject floor;
        [SerializeField] private GameObject coffee;
        [SerializeField] private bool isPlayerCharacterNearBy = false;

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.name == "Player Character")
            {
                isPlayerCharacterNearBy = true;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.name == "Player Character")
            {
                isPlayerCharacterNearBy = false;
            }
        }
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.E) && isPlayerCharacterNearBy==true)
            {
                Debug.Log("E");
                Destroy(coffee);
                Destroy(text);
                Destroy(trigger);
                floor.GetComponent<MeshCollider>().enabled = true;
                floor.GetComponent<MeshRenderer>().enabled = true;
            }
        }
    }
}

