using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AngelaChau
{
    public class ChangeColour : MonoBehaviour
    {
        //This cube will CHNAGE COLOUR when "activiated"
        //CHANGE COLOUR means to CHANGE the cube's colour to a new, random colour
        private void OnEnable()
        {
            EventsManager.OnChangeColourEvent += Activate;
        }

        private void OnDisable()
        {
            EventsManager.OnChangeColourEvent -= Activate;
        }
        private void Activate()
        {
            float redValue = Random.Range(0f, 1f);
            float greenValue = Random.Range(0f, 1f);
            float blueValue = Random.Range(0f, 1f);

            gameObject.GetComponent<MeshRenderer>().material.color = new Color(redValue, greenValue, blueValue);
        }
    }
}

