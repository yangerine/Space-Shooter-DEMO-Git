using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyWave[] enemyWaves;

    public int currentWave;
    public int enemyNumcount = 0;
    public int maxEnemy = 25;
    public bool waveEnd = false;


    private void Start()
    {
        spawnEnemyWaves();
    }

    //day la de spawn enemy
    private void spawnEnemyWaves()
    {
        var waveInfo = enemyWaves[currentWave];
        var startPosition = waveInfo.flyPath[0];
        var EnemyNum = waveInfo.numberOfEnemy;



        for (int i = 0; i < EnemyNum; i++)
        {
            var enemy = Instantiate(waveInfo.enemyPrefab, startPosition, Quaternion.identity);

            var agent = enemy.GetComponent<FlypathAgent>();

            agent.flypath = waveInfo.flyPath;
            agent.flyspeed = waveInfo.speed;
            startPosition += waveInfo.formationOffSet;

            Debug.Log("Enemy Count +1");

        }

        currentWave++;

        if (currentWave < enemyWaves.Length)
        {
            Invoke(nameof(spawnEnemyWaves), waveInfo.nextWaveDelay);

        }

        

    }

    private void Update()
    {
        if (currentWave >= enemyWaves.Length)
        {
            waveEnd = true;
        }
    }


}
