using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{
    public class TransientFloor : MonoBehaviour
    {
        [SerializeField] private GameObject block;
        [SerializeField] private Material tangibleMaterial;
        [SerializeField] private Material intangibleMaterial;
        void Update()
        {
            TurnIntangible();
            TurnTangible();
        }
        public void TurnIntangible()
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

        public void TurnTangible()
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
