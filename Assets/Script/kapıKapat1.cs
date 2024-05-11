using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kapıKapat1 : MonoBehaviour
{
    // Start is called before the first frame update

    //public GameObject colliderKutu;
    public GameObject solKapı;
    public GameObject sagKapı;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Npc")) 
        {
            solKapı.transform.Rotate(Vector3.forward, -90f);
            sagKapı.transform.Rotate(Vector3.forward, 90f);
            //colliderKutu.SetActive(false);

        }
        
    }
}
