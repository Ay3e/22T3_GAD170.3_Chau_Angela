using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AngelaChau
{
    public class PaperHazard : MonoBehaviour
    {
        private int sceneNumber;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene(sceneNumber);
            }
        }
    }
}

