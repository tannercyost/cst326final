using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float hp = Constants.StartHP;
    private float score;

    void Awake()
    {
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
        CanSwipe = false;
    }

    public GameState GameState { get; set; }

    public bool CanSwipe { get; set; }

    private void Die()
    {
        InterfaceManager.Instance.SetStatus(Constants.StatusDeadTapToStart);
        this.GameState = GameState.Dead;
    }

    public void Damage(float dmg)
    {
        hp -= dmg;
        UpdateHealthText();
        if (hp <= 0)
        {
            Die();
            Debug.Log("Dead");
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


