using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DialogueEditor;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Slider soulBar;
    public int soulValue;

    public NPCConversation conversation;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Update()
    {
        soulBar.value = soulValue;

        if (Input.GetKeyDown(KeyCode.X))
        {
            ConversationManager.Instance.StartConversation(conversation);
        }
    }
}
