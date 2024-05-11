using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kapıKapat2 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Npc"))
        {
            transform.Rotate(Vector3.forward, -90f);
        }
    }
}
