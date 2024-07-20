using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
  public int playerScore;
  public Text scoreText;
  public GameObject gameOverScreen;
  public GameObject menuScreen;
  public GameObject bird;
  public static bool isGameStarted = false;
  public float gravityScale;

  public void Start()
  {
    if (isGameStarted)
      StartGame();
  }

  [ContextMenu("Increase Score")]
  public void AddScore(int scoreToAdd)
  {
    playerScore += scoreToAdd;
    scoreText.text = playerScore.ToString();
  }

  public void RestartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void GameOver()
  {
    gameOverScreen.SetActive(true);
  }

  public void StartGame()
  {
    isGameStarted = true;
    menuScreen.SetActive(false);
    var birdRB = bird.GetComponent<Rigidbody2D>();
    birdRB.gravityScale = gravityScale;
  }
}
