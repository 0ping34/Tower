using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Wave
{
    [System.Serializable]
    public class EnemySpawn
    {
        public GameObject enemyType;
        public int count;
    }

    public EnemySpawn[] enemySpawns;
    public float rate;
}

