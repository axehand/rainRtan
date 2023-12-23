using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class gameManager : MonoBehaviour
{

    public GameObject rain;
    public static gameManager I;
    public Text scoreText;
    public Text timeText;
    public GameObject panel;
    int totalScore;
    float limit = 60f;
    // Start is called before the first frame update
    void Awake()
    {
        I = this;
    }
    void initGame()
    {
        Time.timeScale = 1.0f;
        totalScore = 0;
        limit = 30.0f;
    }
    void Start()
    {
        InvokeRepeating("MakeRain", 0, 0.5f);
        initGame();
    }

    // Update is called once per frame
    void Update()
    {
        limit -= Time.deltaTime;
        if (limit < 0)
        {
            limit = 0.0f;
            panel.SetActive(true);
            Time.timeScale = 0.0f;
        }
        timeText.text = limit.ToString("N2");

    }
    void MakeRain()
    {
        Instantiate(rain);
    }
    public void addScore(int score)
    {
        totalScore += score;
        scoreText.text = totalScore.ToString();
    }
    public void retry()
    {
        SceneManager.LoadScene("MainScene");
    }
}
