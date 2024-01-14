using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WavesUi : MonoBehaviour
{
    public Text waveText;
    public WaveSpawn waveSpawn;

    void Start()
    {
        UpdateWaveCount(); // Initial update
    }

    public void UpdateWaveCount()
    {
        if (waveSpawn != null)
        {
            int remainingWaves = waveSpawn.waves.Length - waveSpawn.waveIndex;
            waveText.text = "Remaining Waves: " + remainingWaves;
        }
    }

}
