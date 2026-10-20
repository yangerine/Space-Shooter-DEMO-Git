using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FlypathAgent : MonoBehaviour
{
    public FlyPath flypath;
    public float flyspeed;
    private int nextIndex = 1; //=1 vi diem [0] da duoc gan tu ham start()
    

    //start game thi gan vi tri hien tai voi diem flypath dau tien(waypoints[i])
    //private void Start() => transform.position = flypath[0];
    

    private void Update()
    {
        if (flypath == null) return;//check xem enemy co waypoints gan vao khong

        if (nextIndex >= flypath.waypoints.Length) return; //check xem enemy bay qua het cac waypoint hay chua

        if (transform.position != flypath[nextIndex])//neu vi tri hien tai != diem can bay
        {
            //fly to the next waypoint
            FlyToNextWaypoints();
            LookAt(flypath[nextIndex]);
            

        }
        else //neu vi tri hien tai dang  = diem bay
        {
            nextIndex++;
        }

    }

    private void LookAt(Vector2 destination)
    {
        Vector2 position = transform.position;
        var lookDirection = destination - position;

        //check khoang cach tu vi tri enemy den diem bay, neu qua gan thi return
        if (lookDirection.magnitude < 0.01f) return;

        var angle = Vector2.SignedAngle(Vector3.down, lookDirection);//tinh goc lech giua huong goc cura enemy va huong bay
        transform.rotation = Quaternion.Euler(0,0,angle);//ap dung goc xoay len chuyen dong cua tau
    }

    private void FlyToNextWaypoints()
    {
        transform.position = Vector3.MoveTowards(transform.position, flypath[nextIndex], flyspeed * Time.deltaTime);
        //MoveTowards = ham co san cua Unity de di chuyen tu diem vector A sang B voi toc do float
    }
}
