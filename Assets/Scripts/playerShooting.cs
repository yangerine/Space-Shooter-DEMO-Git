using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; //de class public de co the gan prefab vao script

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);

        }
    }
}
