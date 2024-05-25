using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class waterCollideController : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("DesignThinkingMountain");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("DesignThinkingMountain");
        }

    }
   

}
