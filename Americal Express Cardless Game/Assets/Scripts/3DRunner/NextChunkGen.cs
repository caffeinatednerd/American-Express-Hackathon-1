using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class NextChunkGen : MonoBehaviour
{
    public GameObject[] nextChunkToBeGenerated;

    public bool isGenerated = false;

    public GameObject triggerObject;

    private void OnTriggerEnter(Collider collision)
    {
        if (!isGenerated)
        {
            int randomGenerator = Random.Range(0, nextChunkToBeGenerated.Length);

            Instantiate(nextChunkToBeGenerated[randomGenerator], transform.position + new Vector3(0, 0, 30), Quaternion.identity, null);
            Instantiate(triggerObject, transform.position + new Vector3(0, 0, 30), Quaternion.identity, null);

            isGenerated = true;
        }
    }
    
}
