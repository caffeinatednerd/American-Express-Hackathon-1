using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Powers : MonoBehaviour
{
    public bool isSanitizer;
    public bool isVirus;
    public bool isCard;

    public float healthIncreaseFactor;
    public float healthDecreaseFactor;

    public float speedBooster;
    public float jumpBooster;

    public float duration = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (isSanitizer == true)
            {
                HealthIncreaser(collision);
            }
            else if (isVirus == true)
            {
                HealthDecreaser(collision);
            }
            else if (isCard == true)
            {
                StartCoroutine(CardBooster(collision));
            }
        }
    }

    void HealthIncreaser(Collider2D player)
    {
        Player health = player.GetComponent<Player>();

        health.currentHealth += healthIncreaseFactor;

        if (health.currentHealth >= 100)
            health.currentHealth = health.maxHealth;

        Destroy(gameObject);
    }

    void HealthDecreaser(Collider2D player)
    {
        Player health = player.GetComponent<Player>();

        health.currentHealth -= healthDecreaseFactor;

        Destroy(gameObject);
    }

    IEnumerator CardBooster(Collider2D player)
    {
        PlatformerCharacter2D character2D = player.GetComponent<PlatformerCharacter2D>();

        Player health = player.GetComponent<Player>();

        //adding the power up
        character2D.m_JumpForce += jumpBooster;
        character2D.m_MaxSpeed += speedBooster;
        health.currentHealth += healthIncreaseFactor;

        if (health.currentHealth >= 100)
            health.currentHealth = health.maxHealth;

        //disabling the component
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        //wating for x seconds
        yield return new WaitForSeconds(duration);

        //removing the power up
        character2D.m_JumpForce -= jumpBooster;
        character2D.m_MaxSpeed -= speedBooster;

        //destorying the gameobject
        Destroy(gameObject);
    }
}
