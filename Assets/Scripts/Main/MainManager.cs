using UnityEngine;

public class MainManager : Manager<MainManager>
{
    //DontDestroyOnLoad 적용할지 정하는 필드
    protected override bool isPersistent => false;
    
    //Camera Init을 위한 필드, Camera와 player의 직접연결을 피하기 위해
    [SerializeField] MainCamera mainCamera;
    public Player player;
    Vector2 mapMinBound = new Vector2(-7, -3);
    Vector2 mapMaxBound = new Vector2(7, 14);

    void Start()
    {
        mainCamera.Init(player.transform, mapMinBound, mapMaxBound);
        InitPlayerPosition();
    }

    //로드 시에 플레이어를 LastMainPosition으로 초기화
    void InitPlayerPosition()
    {
        Vector3 newPosition = player.transform.position;
        newPosition = GameManager.Instance.playerData.LastMainPosition;
        player.transform.position = newPosition;
    }
}
