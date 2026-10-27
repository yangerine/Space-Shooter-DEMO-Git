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
        //them dieu kien win game when survive
        //enemy spawn het or no enemy in the main camera but the player still alive
        //to achieve this -> enemy detection for the main screen?
        
        
    }

    //ham nay chua goi -> goi ham nay o dau va khi nao?
    //check khi dang spawn?
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
