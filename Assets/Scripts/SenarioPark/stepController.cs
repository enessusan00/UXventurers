using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class stepController : MonoBehaviour
{
    
    
  
    [SerializeField]
    private GameObject getText;

    public static bool isGet;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            getText.gameObject.SetActive(true);  // Oyuncu alana girdiğinde metni göster
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                countListener.Count++;
                getText.gameObject.SetActive(false);
                transform.gameObject.SetActive(false);
            }
        }
        //Show talk(E)

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            getText.gameObject.SetActive(false);  // Oyuncu alandan çıktığında metni gizle
        }
    }
}
