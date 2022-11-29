using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{
    
    public class PaperHazard : MonoBehaviour
    {
        [SerializeField] Transform respawn;
        [SerializeField] Transform characterLocation;
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("PlayerCharacter Died");
            //if player touches paper
            //restart scene
            characterLocation.transform.position = respawn.transform.position;
        }

        //if(Input.GetKeyDown(KeyCode.E))
        //{
        //  DO THE THING
        //  1. set UI gameobject to ACTIVE
        //  2. if the player presses the button 
        //}
    }
}

