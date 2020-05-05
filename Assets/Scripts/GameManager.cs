using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float hp = Constants.StartHP;
    private float score;
    private float highScore;
    public float globalSpeed;
    void Awake()
    {
        highScore = PlayerPrefs.GetFloat("highScore");
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
    }

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
                
            }
            return instance;
        }
    }

    protected GameManager()
    {
        GameState = GameState.Start;
    }

    public GameState GameState { get; set; }


    private void Die()
    {
        if (score > highScore)
        {
            PlayerPrefs.SetFloat("highScore", score);
        }
        InterfaceManager.Instance.UpdateHighScoreText();
        InterfaceManager.Instance.SetStatus(Constants.StatusDead);
        InterfaceManager.Instance.ShowButton();
        ResetScore();
        GameState = GameState.Dead;
    }

    public void Damage(float dmg)
    {
        hp -= dmg;
        UpdateHealthText();
        if (hp <= 0)
        {
            Die();
            return;
        }
        
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreText();
    }

    public void SetScore(float value)
    {
        score = value;
        UpdateScoreText();
    }

    public void IncreaseScore(float value)
    {
        score += value;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        InterfaceManager.Instance.UpdateScoreText(score);
    }

    private void UpdateHealthText()
    {
        InterfaceManager.Instance.UpdateHealthText(hp);
    }
}


