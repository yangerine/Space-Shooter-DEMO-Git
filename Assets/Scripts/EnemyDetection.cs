using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    private bool enemyInside = false;
    public LayerMask enemyLayer;
    private Collider2D rbcollider;

    //private void OnTriggerStay2D(Collider2D collision) //collision nay can sua lai 
    //{
    //    if (collision.CompareTag("Enemy"))
    //    {
    //        Debug.Log("Enemies is still inside the screen.");
    //        enemyInside = true;
    //    } else
    //    {
    //        Debug.Log("Enemies is outside of the screen.");
    //        enemyInside = false;
    //    }
    //}

    private void Update()
    {
        var isInside = Physics2D.IsTouchingLayers(rbcollider, enemyLayer);

        if (isInside)
        {
            Debug.Log("Enemies is still inside the screen");
        }
    }

}
