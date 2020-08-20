using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
    public float multiplicationFactor = 5;

    public HealthBar healthBar;
    //public GameObject deathEffect;

    public GameObject gameOverCanvas;
    public GameObject mainCamera;

    public GameObject player;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        currentHealth -= Time.deltaTime * multiplicationFactor;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
            Debug.Log("Die is called");
        }
    }

    public void Die()
    {
        Debug.Log("Inside Die");
        Destroy(player);
        mainCamera.SetActive(true);
        gameOverCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
    }
}
