using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyWave[] enemyWaves;

    private int currentWave;

    private void Start()
    {
        
    }

    private void spawnEnemyWaves()
    {
        var waveInfo = enemyWaves[currentWave];
        var startPosition = waveInfo.flyPath[0];
        for (int i = 0; i < waveInfo.numberOfEnemy; i++)
        {
            var enemy = Instantiate(waveInfo.enemyPrefab, startPosition, Quaternion.identity);

            var agent = enemy.GetComponent<FlypathAgent>();
            agent.flypath = waveInfo.flyPath;
            agent.flyspeed = waveInfo.speed;
            startPosition = waveInfo.formationOffSet;

        }

        currentWave++;

        if (currentWave < enemyWaves.Length) {
            Invoke(nameof(spawnEnemyWaves), waveInfo.nextWaveDelay);
            
        }

}
