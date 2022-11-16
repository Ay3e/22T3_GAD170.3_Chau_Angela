using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{
    public class PaperHazard : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("PlayerCharacter Died");
            //if player touches paper
            //restart scene
        }
    }
}

