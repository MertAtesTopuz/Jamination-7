using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class MarketCLose : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject marketMenu;
    public GameObject marketButton;
    void Start()
    {
        marketMenu.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MarketOff()
    {
        if (marketMenu == true)
        {
            marketMenu.SetActive (false);
            marketButton.SetActive (true);
        }
      
    }
}
