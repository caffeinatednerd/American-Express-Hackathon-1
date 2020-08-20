using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    public bool isIntroduction00;
    public bool isIntroduction01;
    public bool isIntroduction02;
    public bool isIntroduction03;

    public GameObject introductionCanvas00;
    public GameObject introductionCanvas01;
    public GameObject introductionCanvas02;
    public GameObject introductionCanvas03;

    private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player"))
       {
            if (isIntroduction00 == true)
            {
                introductionCanvas00.SetActive(true);
            }
            else if (isIntroduction01 == true)
            {
                introductionCanvas01.SetActive(true);
            }
            else if (isIntroduction02 == true)
            {
                introductionCanvas02.SetActive(true);
            }
            else if (isIntroduction03 == true)
            {
                introductionCanvas03.SetActive(true);
            }
       }
    }
}