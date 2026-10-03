using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.mousePosition);

        var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Input.mousePosition: lay vi tri cua chuot tren screen (pixel)
        //ScreenToWorldPoint(): chuyen doi toa do cua mouse va hien thi ra screen 
        //vi gia tri tren la 1 vector3 nen gan gia tri cua vector3 cho bien worldPoint

        worldPoint.z = 0;
        transform.position = worldPoint;
        //gan toa do cho position cua gameObject dc gan cho script nay
    }
}
