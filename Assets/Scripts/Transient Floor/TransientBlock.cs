using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{
    public class TransientBlock : MonoBehaviour
    {
        /*   1. Check what state the block is in:
                 - If state is tangible, Set to intangible
                     - Disable box collider
                     - Change material to “intangible”
                 - Else, if state is intangible, set to tangible
                     - Enable block collider
                     - Change material to “tangible”
         */
        [SerializeField] private GameObject block;
        [SerializeField] private Material tangibleMaterial;
        [SerializeField] private Material intangibleMaterial;

        private void Start()
        {
            
            TurnIntangible();
        }

        private void TurnTangible()
        {
            //if block collider is enabled
            if (block.GetComponent<BoxCollider>().enabled == true)
            {
                //... disble the box collider
                block.GetComponent<BoxCollider>().enabled = false;
                // and change the material
                block.GetComponent<MeshRenderer>().material = intangibleMaterial;
            }
            
        }

        private void TurnIntangible()
        {
            //if block collider is enabled
            if (block.GetComponent<BoxCollider>().enabled == false)
            {
                //... disble the box collider
                block.GetComponent<BoxCollider>().enabled = true;
                // and change the material
                block.GetComponent<MeshRenderer>().material = tangibleMaterial;
            }

        }
    }
}

