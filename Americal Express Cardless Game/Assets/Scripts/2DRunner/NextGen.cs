using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextGen : MonoBehaviour
{
    public GameObject[] nextGen;

    private bool isGenerated = false;
    public GameObject triggerObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isGenerated)
        {
            int random = Random.Range(0, nextGen.Length);

            Instantiate(nextGen[random], transform.position + new Vector3(20, 0, 0), Quaternion.identity, null);
            Instantiate(triggerObject, transform.position + new Vector3(20, 0, 0), Quaternion.identity, null);

            isGenerated = true;
        }
    }
}
