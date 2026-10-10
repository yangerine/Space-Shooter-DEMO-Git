using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //refer to the enemy health
    public EnemyHealth health;
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check xem collsion object co duoc gan script PlayerHealth hay khong
        var player_health = collision.GetComponent<PlayerHealth>();

        if (player_health != null)
        {
            player_health.take_damage(damage);
            health.take_damage(1000);
            //because this is an enemy suicide attack
            //when the enemy collide with the player
            //both take damage and the enemy insta die -> hence the 1000 damage taken
        }
    }
}
