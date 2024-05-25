using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;
using UnityEngine.UI;
public class ahmetConversationStart : MonoBehaviour
{
    [SerializeField]
    private NPCConversation myConversation;
    [SerializeField]
    private GameObject talkPrompt;

    public static bool isAhmetInteract;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            talkPrompt.gameObject.SetActive(true);  // Oyuncu alana girdiğinde metni göster
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player")){
            if(Input.GetKeyDown(KeyCode.E)){
                ConversationManager.Instance.StartConversation(myConversation);
                talkPrompt.gameObject.SetActive(false);
                isAhmetInteract = true;
            }
        }
        //Show talk(E)

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            talkPrompt.gameObject.SetActive(false);  // Oyuncu alandan çıktığında metni gizle
        }
    }
}