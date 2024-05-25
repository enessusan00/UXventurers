using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using TMPro;
using UnityEngine;

public class countListener : MonoBehaviour
{
    public static int Count;
    [SerializeField]
    private NPCConversation helloConvesation;
    [SerializeField]
    private NPCConversation endConversation;

    [SerializeField]
    public TextMeshProUGUI countText;
    [SerializeField]
    public GameObject door;

    private bool isEnd = false;


    // Update is called once per frame
    void Update()
    {
        countText.text = $"{Count} / 7";
        if(Count == 7)
        {
            door.gameObject.SetActive(false);
            if(isEnd== false)
            {
                isEnd = true;
            ConversationManager.Instance.StartConversation(endConversation);
            }
        }
    }

    private void Start()
    {
        StartCoroutine(Wait(2));
    }

    private IEnumerator Wait(float waitTime)
    {


        yield return new WaitForSeconds(waitTime);
        ConversationManager.Instance.StartConversation(helloConvesation);

    }
}
