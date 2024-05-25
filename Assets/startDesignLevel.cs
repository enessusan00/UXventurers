using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;

public class startDesignLevel : MonoBehaviour
{
    [SerializeField]
    private NPCConversation startonversation;

    private void Start()
    {
        StartCoroutine(WaitForStart(1));
    }

    private IEnumerator WaitForStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        ConversationManager.Instance.StartConversation(startonversation);
    }
}
