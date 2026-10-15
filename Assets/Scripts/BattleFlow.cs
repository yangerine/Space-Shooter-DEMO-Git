using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI;
    public PlayerHealth playerHealth;
    public GameObject BGM;

    // Start is called before the first frame update
    void Start()
    {
        //tat man hinh game over khi game bat
        gameOverUI.SetActive(false);

        //them ham onGameOver vao event onDead
        playerHealth.onDead += onGameOver;
    }

    private void onGameOver()
    {
        gameOverUI.SetActive(true);
        BGM.SetActive(false);
    }

}
