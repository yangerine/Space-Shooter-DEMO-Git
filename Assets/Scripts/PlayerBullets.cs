using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullets : MonoBehaviour
{
    [SerializeField] float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //lay vi tri hien tai cua bullet
        var new_position = transform.position;

        //di chuyen toa do y theo speed per frame
        new_position.y += speed * Time.deltaTime;

        //update gia tri toa do moi cho position?
        transform.position = new_position;
    }
}
