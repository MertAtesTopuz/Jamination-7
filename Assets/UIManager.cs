using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DialogueEditor;
using Unity.VisualScripting;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Slider soulBar;
    public int soulValue;
    

    public NPCConversation conversation1, conversation2, conversation3;
    public NPCConversation mainConversation;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Update()
    {
        soulBar.value = soulValue;

        switch (NpcSpawner.instance.npcCounter)
        {
            case 0:
                mainConversation = conversation1;
                break;
            
            case 1:
                mainConversation = conversation2;
                break;

            case 2:
                mainConversation = conversation3;
                break;
        }


        if (Input.GetKeyDown(KeyCode.X))
        {
            ConversationManager.Instance.StartConversation(mainConversation);
        }
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Npc"))
    //    {
    //        ConversationManager.Instance.StartConversation(mainConversation);
    //    }
    //}
}
