using UnityEngine;

public class MainManager : Manager<MainManager>
{
    //DontDestroyOnLoad �������� ���ϴ� �ʵ�
    protected override bool isPersistent => false;
    
    //Camera Init�� ���� �ʵ�, Camera�� player�� ���������� ���ϱ� ����
    [SerializeField] MainCamera mainCamera;
    public Player player;
    Vector2 mapMinBound = new Vector2(-7, -3);
    Vector2 mapMaxBound = new Vector2(7, 14);

    void Start()
    {
        mainCamera.Init(player.transform, mapMinBound, mapMaxBound);
        InitPlayerPosition();
    }

    //�ε� �ÿ� �÷��̾ LastMainPosition���� �ʱ�ȭ
    void InitPlayerPosition()
    {
        Vector3 newPosition = player.transform.position;
        newPosition = GameManager.Instance.playerData.LastMainPosition;
        player.transform.position = newPosition;
    }
}
