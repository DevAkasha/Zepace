using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIManager : Manager<MainUIManager>
{
    //DontDestroyOnLoad ������ ���� �ʵ�
    protected override bool isPersistent => false;

    //miniGameResultView ������ ���� �ʵ�
    [SerializeField] Image miniGameResultView;
    [SerializeField] Text miniGameResult;
    [SerializeField] Text miniGameBestScore;

    //leaderBoardView ������ ���� �ʵ�
    [SerializeField] Image leaderBoardView;
    [SerializeField] Text miniGameNameText;
    [SerializeField] Text miniGameBestScoreText;
    [SerializeField] Text successScoreText;

    //�ڵ� �ݱ� �ð�
    float autoCloseTime = 2f;

    GameManager gameManager;

    protected override void Awake()
    {
        base.Awake();
        gameManager = GameManager.Instance;
        miniGameResultView.gameObject.SetActive(false);
        leaderBoardView.gameObject.SetActive(false);
    }

    void Start()
    {        
        //If a scene other than the minigame scene is added, this code must be modified.
        int lastScneIndex = gameManager.playerData.lastSceneIndex;
        if (lastScneIndex > 1) OpenMiniGameResultView(lastScneIndex - 1);
    }

    void OpenMiniGameResultView(int miniGameNumber)
    {
        bool isMiniGameOwnResult = gameManager.miniGameSucessScore[miniGameNumber-1] <= gameManager.playerData.MiniGameBestScore[miniGameNumber-1];
        miniGameResult.text = isMiniGameOwnResult ? "Success" : "Fail";
        miniGameBestScore.text = gameManager.playerData.MiniGameBestScore[miniGameNumber - 1].ToString();
        miniGameResultView.gameObject.SetActive(true);
        Invoke(nameof(CloseMiniGameOneResultView), autoCloseTime);
    }
    void CloseMiniGameOneResultView()
    {
        miniGameResultView.gameObject.SetActive(false);
    }

    public void OpenLeaderBoard(int leaderBoardIndex)
    {
        switch (leaderBoardIndex)
        {
            case 1:
                miniGameNameText.text = "FlappyPlane";
                miniGameBestScoreText.text = gameManager.playerData.MiniGameBestScore[0].ToString();
                successScoreText.text = gameManager.miniGameSucessScore[0].ToString();
                break;
            case 2:
                miniGameNameText.text = "������";
                miniGameBestScoreText.text = gameManager.playerData.MiniGameBestScore[1].ToString();
                successScoreText.text = gameManager.miniGameSucessScore[1].ToString();
                break;
        }
        leaderBoardView.gameObject.SetActive(true);
        Invoke(nameof(CloseLeaderBoard), autoCloseTime);
    }

    void CloseLeaderBoard()
    {
        leaderBoardView.gameObject.SetActive(false);
    }
}
