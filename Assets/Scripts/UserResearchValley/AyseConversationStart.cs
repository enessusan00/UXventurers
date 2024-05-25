using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;
using UnityEngine.UI;

public class ayseConversationStart : MonoBehaviour
{
    [SerializeField]
    private NPCConversation myConversation;
    [SerializeField]
    private GameObject talkPrompt;
    public static bool isAyseInteract;

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
            Debug.Log("girdi");

            if(Input.GetKeyDown(KeyCode.E)){
                ConversationManager.Instance.StartConversation(myConversation);
                talkPrompt.gameObject.SetActive(false);
                isAyseInteract = true;
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