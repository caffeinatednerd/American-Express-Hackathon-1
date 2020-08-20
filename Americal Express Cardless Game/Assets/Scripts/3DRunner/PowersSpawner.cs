using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowersSpawner : MonoBehaviour
{
    public GameObject[] handSanitizer;
    public GameObject[] virus;
    public GameObject card;

    //private bool isTrigger = false;
    public int spwanCount;

    //Difficulty Level
    public bool isEasy;
    public bool isMedium;
    public bool isHard;

    
    private void OnTriggerEnter(Collider other)
    {
        int randomSelect = Random.Range(0, 100);
        //int randomCardSelect = Random.Range(0, 10);

        //random spwaner of objects;
        int randomSanitizer = Random.Range(0, handSanitizer.Length);
        int randomVirus = Random.Range(0, virus.Length);

        //range spawner
        int spwanRangeX = Random.Range(-5, 5);
        int spwanRangeZ = Random.Range(-1, 29);

        if (other.CompareTag("Player"))
        {
            if (isEasy == true)
            {
                while (spwanCount < 10)
                {
                    //card generation
                    if (randomSelect < 20)
                    {
                        Instantiate(card, transform.position + new Vector3(spwanRangeX, 1, spwanRangeZ), Quaternion.identity);
                    }
                    //virus and sanitizer generator
                    if (randomSelect < 70)
                    {
                        Instantiate(handSanitizer[randomSanitizer], transform.position + new Vector3(spwanRangeX, 1, spwanRangeZ), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(virus[randomVirus], transform.position + new Vector3(spwanRangeX, 1, spwanRangeZ), Quaternion.identity);
                    }

                    spwanCount++;
                }
            }
            else if (isMedium == true)
            {
                while (spwanCount < 10)
                {
                    //card generation
                    if (randomSelect < 15)
                    {
                        Instantiate(card, transform.position + new Vector3(spwanRangeX, 1, spwanRangeZ), Quaternion.identity);
                    }
                    //virus and sanitizer generator
                    if (randomSelect < 50)
                    {
                        Instantiate(handSanitizer[randomSanitizer], transform.position + new Vector3(spwanRangeX, 1, spwanRangeZ), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(virus[randomVirus], transform.position + new Vector3(spwanRangeX, 1, spwanRangeZ), Quaternion.identity);
                    }

                    spwanCount++;
                }
            }
            else if (isHard == true)
            {
                while (spwanCount < 10)
                {
                    //card generation
                    if (randomSelect < 10)
                    {
                        Instantiate(card, transform.position + new Vector3(spwanRangeX, 1, spwanRangeZ), Quaternion.identity, null);
                    }
                    //virus and sanitizer generator
                    if (randomSelect < 30)
                    {
                        Instantiate(handSanitizer[randomSanitizer], transform.position + new Vector3(spwanRangeX, 1, spwanRangeZ), Quaternion.identity, null);
                    }
                    else
                    {
                        Instantiate(virus[randomVirus], transform.position + new Vector3(spwanRangeX, 1, spwanRangeZ), Quaternion.identity, null);
                    }

                    spwanCount++;
                }
            }
        }
    }
}