using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DialogueEditor;
public class endConnvtrigger : MonoBehaviour
{

    [SerializeField]
    private NPCConversation endConv;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ConversationManager.Instance.StartConversation(endConv);
        }
    }
}
