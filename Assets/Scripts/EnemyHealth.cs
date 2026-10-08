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
        Destroy(gameObject);
        Debug.Log("An Enemy was hit!");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
