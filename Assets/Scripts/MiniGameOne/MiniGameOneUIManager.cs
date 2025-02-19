using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameOneUIManager : Manager<MiniGameOneUIManager>
{
    protected override bool IsPersistent => false;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI bestScoreText;
    [SerializeField] Image GameOverView;
    [SerializeField] Image TutorialView;

    MiniGameOneManager miniGameOneManager;

    protected override void Awake()
    {
        base.Awake();
        GameOverView.gameObject.SetActive(false);
        TutorialView.gameObject.SetActive(false);
    }
    void Start()
    {
        miniGameOneManager = MiniGameOneManager.Instance;
        bestScoreText.text = miniGameOneManager.bestScore.ToString();
        //현재 씬에서 로드된 것이 아니면
        if (GameManager.Instance.playerData.lastSceneIndex != 2)
        {
            Time.timeScale = 0f;
            TutorialView.gameObject.SetActive(true);
        }
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
        GameManager.Instance.playerData.MiniGameOneBestScore = MiniGameOneManager.Instance.bestScore;
        MiniGameOneManager.Instance.RestartGame();
    }
    public void OnExitButton()
    {
        GameManager.Instance.playerData.MiniGameOneBestScore = MiniGameOneManager.Instance.bestScore;
        GameManager.Instance.MoveScene(1);
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
}
