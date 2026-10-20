using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlypathAgent : MonoBehaviour
{
    public FlyPath flypath;
    public float flyspeed;
    private int nextIndex = 1; //=1 vi diem [0] da duoc gan tu ham start()
    

    //start game thi gan vi tri hien tai voi diem flypath dau tien(waypoints[i])
    private void Start()
    {
        transform.position = flypath[0];
    }

    private void Update()
    {
        if (flypath == null) return;//check xem enemy co waypoints gan vao khong

        if (nextIndex >= flypath.waypoints.Length) return; //check xem enemy bay qua het cac waypoint hay chua

        if (transform.position != flypath[nextIndex])//neu vi tri hien tai != diem can bay
        {
            //fly to the next waypoint
            FlyToNextWaypoints();
        }
        else //neu vi tri hien tai dang  = diem bay
        {
            nextIndex++;
        }

    }

    private void FlyToNextWaypoints()
    {
        transform.position = Vector3.MoveTowards(transform.position, flypath[nextIndex], flyspeed * Time.deltaTime);
        //MoveTowards = ham co san cua Unity de di chuyen tu diem vector A sang B voi toc do float
    }
}
