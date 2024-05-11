using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketMenu : MonoBehaviour
{
    
    public GameObject marketMenu;
    private bool marketOn = false;
    public GameObject marketButton;
    void Start()
    {
        
        marketMenu.SetActive(false);
    }

    //public void Update()
    //{
    //    while (marketOn == true && Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        marketMenu.SetActive(false) ;
    //    }
    //}
    public void MarketOpen()
    {
        if (marketOn == false) 
        {
            marketMenu.SetActive (true);
            marketButton.SetActive (false);

        }
    }
    
}
