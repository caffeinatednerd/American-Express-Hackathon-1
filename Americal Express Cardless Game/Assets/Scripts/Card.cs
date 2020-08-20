using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public GameObject amexCard;
    public GameObject amexCardCanvas;

    public bool isTriggerEnter;

    private void OnTriggerEnter(Collider other)
    {
        if (isTriggerEnter == true)
        {
            amexCard.SetActive(true);
            amexCardCanvas.SetActive(true);
        }
        else
        {
            amexCard.SetActive(false);
            amexCardCanvas.SetActive(false);
        }
    }
}
