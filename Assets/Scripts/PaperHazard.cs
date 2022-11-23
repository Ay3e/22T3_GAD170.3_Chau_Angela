using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{
    
    public class PaperHazard : MonoBehaviour
    {
        public GameObject playerCharacter;
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("PlayerCharacter Died");
            //if player touches paper
            //restart scene
            playerCharacter.GetComponent<Transform>().transform.position = new Vector3(-15, 1, -20);
        }

        //if(Input.GetKeyDown(KeyCode.E))
        //{
        //  DO THE THING
        //  1. set UI gameobject to ACTIVE
        //  2. if the player presses the button 
        //}
    }
}

