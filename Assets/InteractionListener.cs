using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InteractionListener : MonoBehaviour
{

    [SerializeField]
    private NPCConversation myConversation;

    [SerializeField]
    public GameObject door;
    [SerializeField]
    public GameObject stop;

    void Start()
    {
        StartCoroutine(Example());
        
    }
    private void OnEnable()
    {
        ConversationManager.OnConversationEnded += ConversationEnd;
    }
    private void ConversationEnd()
    {
      //  SceneManager.LoadScene("UserResearchValley");

    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds(1);
        ConversationManager.Instance.StartConversation(myConversation);

    }
    private void Update()
    {
        if(emineConversationStart.isEmineInteract && ahmetConversationStart.isAhmetInteract && mehmetConversationStart.isMehmetInteract && zeynepConversationStart.isZeynepInteract && ayseConversationStart.isAyseInteract)

        {
            door.gameObject.SetActive(false);
            stop.gameObject.SetActive(false);
        }

    }
}
