using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceManager : MonoBehaviour
{
    //public TextMeshPro ScoreText, StatusText;
    public TextMeshProUGUI ScoreText, StatusText, HealthText, HighScoreText;
    public Button PlayAgain;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            UpdateScoreText(0);
            UpdateHealthText(Constants.StartHP);

            UpdateHighScoreText(PlayerPrefs.GetFloat("highScore"));
            PlayAgain.onClick.AddListener(ResetScene);
            PlayAgain.gameObject.SetActive(false);
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

    public void UpdateHighScoreText(float highScore)
    {
        HighScoreText.text = Constants.HighScoreUI + highScore.ToString();
    }

    public void SetStatus(string text)
    {
        StatusText.text = text;
    }

    public void ShowButton()
    {
        PlayAgain.gameObject.SetActive(true);
    }

    private void ResetScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
