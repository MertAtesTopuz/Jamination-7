using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class useEsya : MonoBehaviour , IPointerDownHandler

{
    public GameObject panelOnay;
    void Start()
    {
        panelOnay.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        panelOnay.SetActive(true);
        Debug.Log("basildi");

    }
}
