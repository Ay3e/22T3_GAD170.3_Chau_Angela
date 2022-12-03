using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{
    public class IsEpressed : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E Pressed");
                // Destroy(coffee);
                // floor.GetComponent<BoxCollider>().enabled = true;
                //floor.GetComponent<MeshRenderer>().enabled = true;

            }
        }
    }
}

