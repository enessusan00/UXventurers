using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ahmetBridgeController: MonoBehaviour
{
    [SerializeField]
    private NPCConversation ahmetConversation;
    [SerializeField]
    private GameObject getText;
    [SerializeField]
    private GameObject ahmetBridge;
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

                getText.gameObject.SetActive(false);
                transform.gameObject.SetActive(false);
                ConversationManager.Instance.StartConversation(ahmetConversation);
                ConversationManager.OnConversationEnded += ConversationEnd;
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

    private void ConversationEnd()
    {
        ConversationManager.OnConversationEnded -= ConversationEnd;

        ahmetBridge.gameObject.SetActive(true);
    }
}

