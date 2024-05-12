using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yazıKapat : MonoBehaviour
{
    public GameObject panel;
    public void yaziKapat()
    {
        panel.SetActive(false);
    }
}
