using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{

    public class TransientBlockActivator : MonoBehaviour
    {
        //Needs to knowthe blocks to activate
        //Needs to know which method to call(TurnTangible or TurnIntangible

        [SerializeField] private TransientBlock[] transientBlocksToActivate;

        private void Start()
        {
            ActivateTranscientBlock();
        }
        private void ActivateTranscientBlock()
        {
            //access ALL blocks and turn them tangible
            for(int i=0; i< transientBlocksToActivate.Length; i++)
            {

            }
        }
    }
}

