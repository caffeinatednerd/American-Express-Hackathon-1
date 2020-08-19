using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowersSpawner : MonoBehaviour
{
    public GameObject[] handSanitizer;
    public GameObject[] virus;
    public GameObject card;

    //private bool isTrigger = false;

    //Difficulty Level
    public bool isEasy;
    public bool isMedium;
    public bool isHard;

    //spwan Ranger
    [Range(0, 50)] public int spwanRangeX;
    [Range(0, 50)] public int spwanRangeZ;

    private void OnTriggerEnter(Collider other)
    {
        int randomSelect = Random.Range(0, 100);
        //int randomCardSelect = Random.Range(0, 10);

        //random spwaner of objects;
        int randomSanitizer = Random.Range(0, handSanitizer.Length);
        int randomVirus = Random.Range(0, virus.Length);

        if (other.CompareTag("Player"))
        {
            if (isEasy == true)
            {
                //card generation
                if (randomSelect < 10)
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
                    Instantiate(virus[randomSelect], transform.position + new Vector3(spwanRangeX, 1, spwanRangeZ), Quaternion.identity);
                }
            }
            else if (isMedium == true)
            {
                //card generation
                if (randomSelect < 7)
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
                    Instantiate(virus[randomSelect], transform.position + new Vector3(spwanRangeX, 1, spwanRangeZ), Quaternion.identity);
                }
            }
            else if (isHard == true)
            {
                //card generation
                if (randomSelect < 5)
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
                    Instantiate(virus[randomSelect], transform.position + new Vector3(spwanRangeX, 1, spwanRangeZ), Quaternion.identity, null);
                }
            }
        }
    }
}