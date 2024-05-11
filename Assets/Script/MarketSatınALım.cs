using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketSatınALım : MonoBehaviour
{
    public GameObject bıcak;
    //public GameObject alkol;

    private void Start()
    {
        bıcak.SetActive(false);
        //alkol.SetActive(false);
    }
    public void BıcakAl()
    {
        bıcak.SetActive(true);
    }

    public void AlkolAl()
    {
        //alkol.SetActive(true);
    }
}
