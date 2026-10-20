using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public WayPoint[] waypoints;

    public Vector3 this[int index] => waypoints[index].transform.position;
    //this = cu phap dinh nghia indexer | this[int index] == Flypath.waypoints[i]


    private void Reset()
    {
        waypoints = GetComponent<WayPoint[]>();
        //gom tat ca cac component va cac component con trong gameobject WayPoint va tu dien vao mang waypoints
    }

    private void OnDrawGizmos()
    {
        //neu khong co cac diem waypoints thi return
        if (waypoints == null) return;

        Gizmos.color = Color.green;

        for (int i = 0; i < waypoints.Length - 1 ; i++)
        {
            //ve mot duong thang tu diem waypoints dau den cac diem tiep theo ngay sau no
            Gizmos.DrawLine(waypoints[i].transform.position, waypoints[i+1].transform.position);

        }
    }

}
