using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Character Player { get; private set; }

    private void Start()
    {
        SetData();
    }

    public void SetData()
    {
        Player = new Character("효정", 2, 100, 10, 10, 15, "여전사", "검을 들고 싸우는 여전사입니다.");

        Sprite coinSprite = Resources.Load<Sprite>("Coin");
        Sprite raySprite = Resources.Load<Sprite>("Ray");
        Sprite starSprite = Resources.Load<Sprite>("Star");

        Player.Inventory.Add(new Item("코인", "코인입니다", coinSprite));
        Player.Inventory.Add(new Item("번개", "번개입니다", raySprite));
        Player.Inventory.Add(new Item("별", "별입니다", starSprite));

        UIManager.Instance.MainMenu.SetCharacterInfo(Player);
        UIManager.Instance.Status.SetCharacterInfo(Player);
        UIManager.Instance.Inventory.InitInventoryUI(Player.Inventory);

        UIManager.Instance.MainMenu.OpenMainMenu();
    }
}

