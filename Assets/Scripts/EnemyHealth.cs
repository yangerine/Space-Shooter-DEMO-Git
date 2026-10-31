using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : Health
{
    public static int livingEnemyCount;
    public BattleFlow battleFlow;
    public int enemyDestroyed = 0;


    private void Awake()
    {
        livingEnemyCount++;
    }

    private void Start()
    {
        battleFlow = FindObjectOfType<BattleFlow>();
    }
    protected override void die()
    {

        livingEnemyCount--;
        base.die();
        //battleFlow.OnEnemyDie();
        Debug.Log("An Enemy was hit!");
        enemyDestroyed++;

    }


}
