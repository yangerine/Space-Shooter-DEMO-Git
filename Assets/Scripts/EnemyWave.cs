using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable] //lop du lieu nay duoc hien thi va sua truc tiep tren inspector cua Unity

public class EnemyWave //khong inherit tu class monobehavior
{
    public Transform enemyPrefab;
    public int numberOfEnemy;
    public Vector3 formationOffSet;
    public FlyPath flyPath;
    public float speed;
    public float nextWaveDelay;
}
