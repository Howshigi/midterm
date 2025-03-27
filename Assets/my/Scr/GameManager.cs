using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    
    [Header("UI Elements")]
    // NOTE: TextMeshProUGUI requires "using TMPro"
    public TextMeshProUGUI scoreText;
    // NOTE: TextMeshProUGUI requires "using TMPro"
    public TextMeshProUGUI gameOverText;
    public Button restartButton;

    public GameObject titleScreen;
    public GameObject gameOverScreen;
    public Button easyButton;
    public Button NormalButton;
    public Button hardButton;
    
    private int score;
    private bool isGameActive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Awake()
    {
        easyButton.onClick.AddListener(() =>
        {
            StartGame(1.0f);
        });
        
        NormalButton.onClick.AddListener(() =>
        {
            StartGame(1.5f);
        });
        
        hardButton.onClick.AddListener(() =>
        {
            StartGame(2.0f);
        });
    }
    
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    
    
    
    void StartGame(float difficulty)
    {
        titleScreen.SetActive(false);
        
    }
    
    public void UpdateScore(int score)
    {
        this.score += score;
        scoreText.text = this.score.ToString();
    }
    
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        isGameActive = false;
    }
    public void RestartGame()
    {
        //SceneManager.LoadScene("Main");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}