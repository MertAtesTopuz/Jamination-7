using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEditor.Rendering;


public class signHere : MonoBehaviour
{
    public GameObject kagit;
    public int iVal;
    public int speed = 1;
    private Vector3 targetPosition;
    private bool isMoving = true;
    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        int iVal = ConversationManager.Instance.GetInt("playerIntSign");
        targetPosition = transform.position + transform.forward * 100f;
    }

    // Update is called once per frame
    void Update()
    {
        if(iVal == 2 && isMoving)
        {
            transform.position += transform.forward * speed * Time.deltaTime;

            if (Vector3.Distance(transform.position, targetPosition) >= 0)
            {
                isMoving = false;
            }
        }
    }

    public void AnimUpdaterUp(bool isUp)
    {
        anim.SetBool("isUp", isUp);
    }

    public void AnimUpdaterDown(bool isDown)
    {
        anim.SetBool("isDown", isDown);
    }
}
