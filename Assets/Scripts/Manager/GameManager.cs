using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Manager<GameManager>
{
    public PlayerData playerData;
    int miniGameCount = 2;
    public int[] miniGameSucessScore;

    protected override void Awake()
    {
        base.Awake();
        playerData = new PlayerData(miniGameCount); //���̺� �ε� ���߽� �� ��Ʈ��Ʈ ���
        miniGameSucessScore = new int[] { 10, 0 };
    }

    public void MoveScene(int SceneIndex) //�� ��ȯ�� �� �޼��� ����ؾ� ��. �����ڰ� �����ؾ� ��.
    {
        playerData.lastSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (playerData.lastSceneIndex == 1) playerData.LastMainPosition = MainManager.Instance.player.transform.position;
        SceneManager.LoadScene(SceneIndex);
    }
}
