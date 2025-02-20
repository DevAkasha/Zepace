using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameOneUIManager : Manager<MiniGameOneUIManager>
{
    //DontDestroyOnLoad¸¦ À§ÇÑ field
    protected override bool isPersistent => false;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI bestScoreText;

    [SerializeField] Image GameOverView;
    [SerializeField] Image TutorialView;

    MiniGameOneManager miniGameOneManager;
    GameManager gameManager;

    protected override void Awake()
    {
        base.Awake();
        GameOverView.gameObject.SetActive(false);
        TutorialView.gameObject.SetActive(false);
    }
    void Start()
    {
        miniGameOneManager = MiniGameOneManager.Instance;
        gameManager = GameManager.Instance;
        bestScoreText.text = miniGameOneManager.bestScore.ToString();

        //If it is not loaded in the current scene
        if (GameManager.Instance.playerData.lastSceneIndex != 2)
        {
            Time.timeScale = 0f;
            TutorialView.gameObject.SetActive(true);
        }
        //Tutorial Skip
        else OnStartButton();
    }

    public void AtGameOver()
    {
        GameOverView.gameObject.SetActive(true);
    }
    public void OnStartButton()
    {
        TutorialView.gameObject.SetActive(false);
        miniGameOneManager.GameStart(); 
    }
    public void OnRetryButton()
    {
        GameOverView.gameObject.SetActive(false);
        if (miniGameOneManager.bestScore < miniGameOneManager.currentScore)
            miniGameOneManager.bestScore = miniGameOneManager.currentScore;
        bestScoreText.text = miniGameOneManager.bestScore.ToString();
        gameManager.playerData.MiniGameBestScore[0] = miniGameOneManager.bestScore;
        miniGameOneManager.RestartGame();
    }
    public void OnExitButton()
    {
        if (miniGameOneManager.bestScore < miniGameOneManager.currentScore)
            miniGameOneManager.bestScore = miniGameOneManager.currentScore;
        gameManager.playerData.MiniGameBestScore[0] = miniGameOneManager.bestScore;
        gameManager.MoveScene(1);
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
}
