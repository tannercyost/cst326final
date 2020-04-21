using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InterfaceManager : MonoBehaviour
{
    //public TextMeshPro ScoreText, StatusText;
    public TextMeshProUGUI ScoreText, StatusText;
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

    //singleton implementation
    private static InterfaceManager instance;
    public static InterfaceManager Instance
    {
        get
        {
            if (instance == null)
                instance = new InterfaceManager();

            return instance;
        }
    }

    protected InterfaceManager() {}

    private float score = 0;

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
        ScoreText.text = score.ToString();
    }

    public void SetStatus(string text)
    {
        StatusText.text = text;
    }
}
