using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIManager : Manager<MainUIManager>
{
    protected override bool IsPersistent => false;
    bool isMiniGameOwnResult;

    [SerializeField] Image miniGameOneResultView;
    [SerializeField] Text miniGameOneResult;
    [SerializeField] Text miniGameOneBestScore;

    [SerializeField] Image leaderBoardView;
    [SerializeField] Text miniGameNameText;
    [SerializeField] Text miniGameBestScoreText;
    [SerializeField] Text successScoreText;

    GameManager gameManager;

    protected override void Awake()
    {
        base.Awake();
        gameManager = GameManager.Instance;
        miniGameOneResultView.gameObject.SetActive(false);
        leaderBoardView.gameObject.SetActive(false);
        isMiniGameOwnResult = gameManager.miniGameOneSucessScore <= gameManager.playerData.MiniGameOneBestScore;
    }

    void Start()
    {
        if (gameManager.playerData.lastSceneIndex == 2) OpenMiniGameOneResultView();
    }

    void OpenMiniGameOneResultView()
    {
        miniGameOneResult.text = isMiniGameOwnResult ? "Success" : "Fail";
        miniGameOneBestScore.text = gameManager.playerData.MiniGameOneBestScore.ToString();
        miniGameOneResultView.gameObject.SetActive(true);
        Invoke(nameof(CloseMiniGameOneResultView), 2f);
    }
    void CloseMiniGameOneResultView()
    {
        miniGameOneResultView.gameObject.SetActive(false);
    }

    public void OpenLeaderBoard(int leaderBoardIndex)
    {
        switch (leaderBoardIndex)
        {
            case 1:
                miniGameNameText.text = "FlappyPlane";
                miniGameBestScoreText.text = gameManager.playerData.MiniGameOneBestScore.ToString();
                successScoreText.text = gameManager.miniGameOneSucessScore.ToString();
                break;
            case 2:
                miniGameNameText.text = "°³¹ßÁß";
                miniGameBestScoreText.text = gameManager.playerData.MiniGameOneBestScore.ToString();
                successScoreText.text = gameManager.miniGameTwoSucessScore.ToString();
                break;
        }
        leaderBoardView.gameObject.SetActive(true);
        Invoke(nameof(CloseLeaderBoard), 2f);
    }

    void CloseLeaderBoard()
    {
        leaderBoardView.gameObject.SetActive(false);
    }
}
