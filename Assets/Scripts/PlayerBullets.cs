using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullets : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int damage;

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

        //Destroy(gameObject,5f);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check the object the bullet collides with has an EnemyHealth script attachted to it or not
        var enemy = collision.GetComponent<EnemyHealth>();

        //if enemy exist
        if ( (enemy != null) )
        {
            enemy.take_damage(damage);
        }

        //destroy the bullet gameobject whether the object it pass through die or not
        //Destroy(gameObject);
    }

}
