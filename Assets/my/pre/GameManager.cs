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
    public Button mediumButton;
    public Button hardButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
