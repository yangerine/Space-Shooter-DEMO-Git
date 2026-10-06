using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; //de class public de co the gan prefab vao script
    public float shootingInterval = 1f;
    private float lastBulletTime; //track the last time a bullet was fired

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime > shootingInterval) //ktra xem tgian ban tiep theo co > 1s khong?
            {
                shoot();
                lastBulletTime = Time.time; //reset timer
            }
        }

    }

    private void shoot()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}
