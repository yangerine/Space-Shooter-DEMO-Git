using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : Health
{
    public static int livingEnemyCount;

    private void Awake()
    {
        livingEnemyCount++;
    }

    protected override void die()
    {
        livingEnemyCount--;
        base.die();
        Debug.Log("An Enemy was hit!");
    }


}
