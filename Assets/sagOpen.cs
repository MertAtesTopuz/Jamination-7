using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sagOpen : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Npc"))
        {
            transform.Rotate(Vector3.forward, -90f);
        }
    }

    
}
