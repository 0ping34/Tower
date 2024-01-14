using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startSpeed= 10f;

    [HideInInspector]
    public float speed;

    public int worth = 50;
    public float starthealth = 100;
    public float health=100;

    public GameObject deathEffect;

    [Header("Stuff")]
    public Image healthBar;

    void Start()
    {
        speed = startSpeed;
        health = starthealth;
    }
    public void TakeDamage(float amount) 
    {
        health-=amount;

        healthBar.fillAmount = health / starthealth;

        if(health<=0)
        { 
            Die(); 
        }

    }

    public void Slow(float pct) 
    {
        speed = startSpeed*(1f - pct);
    }

    void Die()
    {
        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect,5f);
        PlayerStats.Money += worth;

        WaveSpawn.EnemiesAlive--;

        Destroy(gameObject);
    }

}
