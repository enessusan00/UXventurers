using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class activityListener : MonoBehaviour
{

    public static int talkCount;
    private bool isFirstStep;
    private bool isSecondStep;
    [SerializeField]
    private NPCConversation firstConv;
    [SerializeField]
    private NPCConversation secondConv;
    [SerializeField]
    private NPCConversation helloConv;

    void Start()
    {
        ConversationManager.Instance.StartConversation(helloConv);
    }

    // Update is called once per frame
    void Update()
    {
        if(talkCount >= 3)
        {
            if (isFirstStep == false)
            {
                isFirstStep = true;
                ConversationManager.OnConversationEnded += ConversationEnd;
               
            }
            if (isSecondStep)
            {
                isSecondStep = false;
                ConversationManager.Instance.StartConversation(secondConv);
            }
        } 
    }
    private void ConversationEnd()
    {
        ConversationManager.OnConversationEnded -= ConversationEnd;
        ConversationManager.Instance.StartConversation(firstConv);

    }
}
