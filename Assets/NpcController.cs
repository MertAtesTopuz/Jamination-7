using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour
{
    public Transform targetPos1, targetPos2;

    private Vector3 mainTargetPos;

    public float speed;

    public bool canReturn;

    void Start()
    {
        targetPos1 = GameObject.FindWithTag("TargetPos1").GetComponent<Transform>();
        targetPos2 = GameObject.FindWithTag("TargetPos2").GetComponent<Transform>();
        mainTargetPos = targetPos1.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, mainTargetPos, speed*Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.V))
        {
            canReturn = true;   
        }

        if (canReturn == true)
        {
            mainTargetPos = targetPos2.position;
        }
    }
}