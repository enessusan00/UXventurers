using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.SceneManagement;

public class childCounter : MonoBehaviour
{
    [SerializeField]
    private NPCConversation myConversation;

    [SerializeField]
    private NPCConversation startonversation;
    private bool isStarted = false;



    private void Start()
    {
        StartCoroutine(WaitForStart(1));
    }
    void Update()
    {
        int childCount = transform.childCount;
        if (childCount <= 5)
        {
            if(isStarted == false)
            {
                isStarted = true;
                StartCoroutine(Wait(2));
        ConversationManager.OnConversationEnded += ConversationEnd;
            }
        }


    }

    private void ConversationEnd()
    {
        ConversationManager.OnConversationEnded -= ConversationEnd;
        SceneManager.LoadScene("SenarioPark");

    }
 

    private IEnumerator Wait(float waitTime)
    {

            yield return new WaitForSeconds(waitTime);
            ConversationManager.Instance.StartConversation(myConversation); 
    }

    private IEnumerator WaitForStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        ConversationManager.Instance.StartConversation(startonversation);
    }
}
