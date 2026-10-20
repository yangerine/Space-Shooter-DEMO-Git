using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public WayPoint[] waypoints;

    private void Reset()
    {
        waypoints = GetComponent<WayPoint[]>();
        //gom tat ca cac component vaf cac component con trong gameobject WayPoint va tu dien vao mang waypoints
    }

}
