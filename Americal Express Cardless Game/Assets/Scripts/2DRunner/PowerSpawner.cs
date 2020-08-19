using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpawner : MonoBehaviour
{
    public GameObject handSanitizer;
    public GameObject virus;
    public GameObject card;

    //private bool isTrigger = false;
    
    //Difficulty Level
    public bool isEasy;
    public bool isMedium;
    public bool isHard;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int randomSelect = Random.Range(0, 100);
        //int randomCardGenerate = Random.Range(0, 10);

        int spwanRangeX = Random.Range(0, 20);
        int spwanRangeY = Random.Range(0, 5);

        if (collision.CompareTag("Player"))
        {
            if (isEasy == true && isMedium == false && isHard == false)
            {
                if (randomSelect < 10)
                {
                    Instantiate(card, transform.position + new Vector3(spwanRangeX, spwanRangeY, 0), Quaternion.identity, null);
                }
                else if (randomSelect < 70)
                {
                    Instantiate(handSanitizer, transform.position + new Vector3(spwanRangeX, spwanRangeY, 0), Quaternion.identity, null);
                }
                else
                {
                    Instantiate(virus, transform.position + new Vector3(spwanRangeX, spwanRangeY, 0), Quaternion.identity, null);
                }
            }
            else if (isEasy == false && isMedium == true && isHard == false)
            {
                if (randomSelect < 5)
                {
                    Instantiate(card, transform.position + new Vector3(spwanRangeX, spwanRangeY, 0), Quaternion.identity, null);
                }
                else if (randomSelect < 50)
                {
                    Instantiate(handSanitizer, transform.position + new Vector3(spwanRangeX, spwanRangeY, 0), Quaternion.identity, null);
                }
                else
                {
                    Instantiate(virus, transform.position + new Vector3(spwanRangeX, spwanRangeY, 0), Quaternion.identity, null);
                }
            }
            else if (isEasy == false && isMedium == false && isHard == true)
            {
                if (randomSelect < 3)
                {
                    Instantiate(handSanitizer, transform.position + new Vector3(spwanRangeX, spwanRangeY, 0), Quaternion.identity, null);
                }
                else if (randomSelect < 30)
                {
                    Instantiate(handSanitizer, transform.position + new Vector3(spwanRangeX, spwanRangeY, 0), Quaternion.identity, null);
                }
                else
                {
                    Instantiate(virus, transform.position + new Vector3(spwanRangeX, spwanRangeY, 0), Quaternion.identity, null);
                }
            }
        }
    }
}
