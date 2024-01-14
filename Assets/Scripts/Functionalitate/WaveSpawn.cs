using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;


public class WaveSpawn : MonoBehaviour
{

    public static int EnemiesAlive = 0;

    public Wave[] waves;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 3f;

    public int waveIndex = 0;

    public Text waveCountdownText;
    public WavesUi wavesUI;

    public Manager manager;
    private void Update()
    {
        if (EnemiesAlive > 0)
        {
            return; // If there are still enemies alive, keep the game running
        }

        if (waveIndex == waves.Length && EnemiesAlive == 0) // Check if all waves have been spawned
        {
            manager.EndGame(); // End the game if there are no enemies left
            return;
        }

        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }

        countdown -= Time.deltaTime;
        waveCountdownText.text = Mathf.Round(countdown).ToString();
    }




    IEnumerator SpawnWave()
    {
        PlayerStats.Rounds++;

        Wave wave = waves[waveIndex];

        foreach (var enemySpawn in wave.enemySpawns)
        {
            for (int i = 0; i < enemySpawn.count; i++)
            {
                SpawnEnemy(enemySpawn.enemyType);
                yield return new WaitForSeconds(1f / wave.rate);
            }
        }

        waveIndex++;
        if (wavesUI != null)
        {
            wavesUI.UpdateWaveCount();
        }

    }


    void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        EnemiesAlive++;
    }

}
