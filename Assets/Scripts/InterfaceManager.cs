using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InterfaceManager : MonoBehaviour
{
    //public TextMeshPro ScoreText, StatusText;
    public TextMeshProUGUI ScoreText, StatusText, HealthText;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            UpdateScoreText(0);
            UpdateHealthText(Constants.StartHP);
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

    public void UpdateHealthText(float hp)
    {
        HealthText.text = Constants.HealthUI + hp.ToString();
    }

    public void UpdateScoreText(float score)
    {
        ScoreText.text = Constants.ScoreUI + score.ToString();
    }

    public void SetStatus(string text)
    {
        StatusText.text = text;
    }
}
