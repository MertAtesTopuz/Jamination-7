using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapıSes : MonoBehaviour
{
    public AudioSource kapıGıcırtı;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Npc"))
        {
            kapıGıcırtı.Play();
        }
    }


}
