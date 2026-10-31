using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI;
    public PlayerHealth playerHealth;
    public GameObject BGM;
    public GameObject gameWinUI;
    public EnemySpawner enemySpawner;
    public EnemyHealth enemyHealth;


    // Start is called before the first frame update
    void Start()
    {

        //tat man hinh game over khi game bat
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);

        //them ham onGameOver vao event onDead
        playerHealth.onDead += onGameOver;
        playerHealth.onDead += onGameWin;
    }

    private void Update()
    {
        if(enemySpawner.waveEnd == true && enemySpawner.maxEnemy == enemyHealth.enemyDestroyed)
        {
            OnEnemyDie();
        }
    }


    public void OnEnemyDie()
    {
        if (EnemyHealth.livingEnemyCount <= 0)
        {
            onGameWin();
        }
    }

    public void returnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void onGameWin()
    {
        gameWinUI.SetActive(true);
        gameOverUI.SetActive(false);
        BGM.SetActive(false);

    }

    private void onGameOver()
    {
        gameOverUI.SetActive(true);
        BGM.SetActive(false);
    }

}
