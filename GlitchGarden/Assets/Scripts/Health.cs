using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Debug.Log("Health < 0");
            TriggerDeathVFX();
            Destroy(gameObject);

        }
    }

    public float GetHealth()
    {
        return health;
    }

    public void ReplenishHealth()
    {
        health = 200;
    }

    private void TriggerDeathVFX()
    {
        if (!deathVFX) { return; }

        GameObject deathVFXObject =  Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(deathVFXObject, 1);
    }

}



//FindObjectOfType<GameSession>().AddToScore(scoreValue);
//Destroy(gameObject);
//GameObject explosion = Instantiate(deathVFX, transform.position, transform.rotation);
//Destroy(explosion, durationOfExplosion);
//AudioSource.PlayClipAtPoint(deathSFX, Camera.main.transform.position, deathSoundVolume);