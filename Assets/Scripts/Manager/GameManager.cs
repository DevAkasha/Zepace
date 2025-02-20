using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Manager<GameManager>
{
    public PlayerData playerData;
    public int miniGameOneSucessScore = 10;
    public int miniGameTwoSucessScore = 0;

    protected override void Awake()
    {
        base.Awake();
        playerData = new PlayerData(); //���̺� �ε� ���߽� �� ��Ʈ��Ʈ ���
    }

    public void MoveScene(int SceneIndex) //�� ��ȯ�� �� �޼��� ����ؾ� ��. �����ڰ� �����ؾ� ��.
    {
        playerData.lastSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (playerData.lastSceneIndex == 1) playerData.LastMainPosition = MainManager.Instance.player.transform.position;
        SceneManager.LoadScene(SceneIndex);
    }
}
