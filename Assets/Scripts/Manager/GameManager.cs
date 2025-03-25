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
        
        var sword = new Item("단검", "짧고 빠른 무기", coinSprite, 5);
        var potion = new Item("HP 포션", "HP를 50 회복합니다", raySprite, 0);

        Player.AddItem(sword);
        Player.AddItem(potion);

        UIManager.Instance.MainMenu.SetCharacterInfo(Player);
        UIManager.Instance.Status.SetCharacterInfo(Player);
        UIManager.Instance.Inventory.InitInventoryUI(Player.Inventory);

        UIManager.Instance.MainMenu.OpenMainMenu();
    }
}

