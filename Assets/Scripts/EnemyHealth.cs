using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosion_prefab;

    //detects when a game object enters the enemy's collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        die();
    }

 
    private void die()
    {
        var explosion = Instantiate(explosion_prefab, transform.position, transform.rotation);
        Destroy(explosion, 0.5f);
        Debug.Log("Explosion!");

        Destroy(gameObject);
        Debug.Log("An Enemy was hit!");
    }


}
