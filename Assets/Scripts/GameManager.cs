using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text timeText;
    [SerializeField] private GameObject gameOverScreen;
    private float gameTimer;
    private bool isGameOver;

    private void Update()
    {
        if (!isGameOver)
        {
            gameTimer += Time.deltaTime;
            timeText.text = gameTimer.ToString("0.00");
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        FindObjectOfType<PlayerController>().enabled = false;
        FindObjectOfType<EnemySpawner>().enabled = false;
        gameOverScreen.SetActive(true);
    }
}