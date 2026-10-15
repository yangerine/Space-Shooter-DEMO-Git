using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosion_prefab;
    public int default_health_point;
    private int health_point;
    public System.Action onDead; //dat ten bien cho su kien
    

    private void Start()
    {
        health_point = default_health_point;
    }

    //take_damage method nhan vao gia tri tham chieu damage
    public void take_damage(int damage)
    {
        //if the HP = 0 from the start -> return
        if (health_point <= 0) 
            return;

        health_point -= damage;
        if (health_point <= 0)
            die();
    }

    //detects when a game object enters the enemy's collider
    public void OnTriggerEnter2D(Collider2D collision)
    {
        die();
    }

    //add virtual so the children of this class can override it and add custom method to it while keeping the core function
    protected virtual void die()
    {
        var explosion = Instantiate(explosion_prefab, transform.position, transform.rotation);
        Destroy(explosion, 1f);
        Debug.Log("Explosion!");

        Destroy(gameObject);
        onDead?.Invoke(); 
        //kich hoat su kien safely

        //toan tu (?.) check xem onDead co dang chua ham nao dang lang nghe khong, neu khong co script nao dc
        //gan thi system se tuw dong bo qua
        //Invoke(): lenh thuc thi su kien -> tat ca ham ket noi voi onDead se chay all at once
    }
}
