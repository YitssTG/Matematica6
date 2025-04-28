using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUIController : MonoBehaviour
{
    public SpaceShip spaceship;
    public GameObject inGamePanel;
    public GameObject gameOverPanel;
    public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI finalScoreText;
    public float currentTime;
    public float savedTime;

    void Start()
    {
        inGamePanel.SetActive(true);
        gameOverPanel.SetActive(false);
        currentTime = 0;
        savedTime = 0;
    }

    private void Update()
    {
        currentTime = Time.deltaTime * currentTime + 1;
        currentScoreText.text = "Puntaje: " + currentTime.ToString();
    }

    public void ShowInGameUI()
    {
        inGamePanel.SetActive(true);
        gameOverPanel.SetActive(false);
        currentTime = 0;
        spaceship.Health = 3;
        spaceship.hasBeenDefeated = false;
    }

    public void ShowGameOverUI()
    {
        inGamePanel.SetActive(false);
        gameOverPanel.SetActive(true);
        savedTime = currentTime;
        finalScoreText.text = "Puntaje: " + savedTime.ToString();
    }
}
