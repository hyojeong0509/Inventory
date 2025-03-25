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
        Player = new Character("ȿ��", 2, 100, 10, 10, 15, "������", "���� ��� �ο�� �������Դϴ�.");

        Sprite coinSprite = Resources.Load<Sprite>("Coin");
        Sprite raySprite = Resources.Load<Sprite>("Ray");
        Sprite starSprite = Resources.Load<Sprite>("Star");

        Player.Inventory.Add(new Item("����", "�����Դϴ�", coinSprite));
        Player.Inventory.Add(new Item("����", "�����Դϴ�", raySprite));
        Player.Inventory.Add(new Item("��", "���Դϴ�", starSprite));

        UIManager.Instance.MainMenu.SetCharacterInfo(Player);
        UIManager.Instance.Status.SetCharacterInfo(Player);
        UIManager.Instance.Inventory.InitInventoryUI(Player.Inventory);

        UIManager.Instance.MainMenu.OpenMainMenu();
    }
}

