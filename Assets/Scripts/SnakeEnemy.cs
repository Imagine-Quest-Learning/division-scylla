using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeEnemy : MonoBehaviour
{
    public int baseHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = baseHealth;
		healthBar.SetMaxHealth(baseHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //temporary - to replace with quick-time attack
        if (Input.GetKeyDown(KeyCode.Space))
		{
			TakeDamage(20);
		}
    }

    public void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}
}
