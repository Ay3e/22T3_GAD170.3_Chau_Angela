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

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
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

