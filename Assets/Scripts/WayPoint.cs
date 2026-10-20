using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, 0.1f);
        //ve hinh cau voi tam dat tai [transform.position] voi ban kinh 0.1f
    }
}
