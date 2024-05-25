using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;

public class conversationTrigger: MonoBehaviour
{
    [SerializeField]
    private NPCConversation myConversation;
    [SerializeField]
    private GameObject talkPrompt;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            talkPrompt.gameObject.SetActive(true);  // Oyuncu alana girdiğinde metni göster
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ConversationManager.Instance.StartConversation(myConversation);
                talkPrompt.gameObject.SetActive(false);
                transform.gameObject.SetActive(false);
                activityListener.talkCount++;
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
