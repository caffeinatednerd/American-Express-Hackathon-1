using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUser : MonoBehaviour
{
    //booleans for instantiate
    public bool isSanitzer;
    public bool isVirus;
    public bool isCard;

    // modifiers
    public float healthIncreaseFactor;
    public float healthDecreaseFactor;
    public float speedBooster;

    //time duration
    public float timeDuration = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isSanitzer == true)
            {
                HealthIncrease(other);
            }
            else if (isVirus == true)
            {
                HealthDecrease(other);
            }
            else if (isCard == true)
            {
                StartCoroutine(CardBooster(other));
            }
        }
    }

    void HealthIncrease (Collider player)
    {
        Player health = player.GetComponent<Player>();

        health.currentHealth += healthIncreaseFactor;

        if (health.currentHealth >= 100)
            health.currentHealth = health.maxHealth;

        Destroy(gameObject);
    }

    void HealthDecrease(Collider player)
    {
        Player health = player.GetComponent<Player>();

        health.currentHealth -= healthDecreaseFactor;

        Destroy(gameObject);
    }

    IEnumerator CardBooster(Collider player)
    {
        PlayerMovement character = player.GetComponent<PlayerMovement>();

        Player health = player.GetComponent<Player>();

        //adding the power up
        character.speed += speedBooster;
        health.currentHealth += healthIncreaseFactor;

        if (health.currentHealth >= 100)
            health.currentHealth = health.maxHealth;

        //disabling the component
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        //wating for x seconds
        yield return new WaitForSeconds(timeDuration);

        //removing the power up
        character.speed -= speedBooster;

        //destorying the gameobject
        Destroy(gameObject);
    }
    /*
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
    }*/
}
