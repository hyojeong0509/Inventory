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

        Sprite swordSprite = Resources.Load<Sprite>("Sword");
        Sprite potionSprite = Resources.Load<Sprite>("Potion");
        
        var sword = new Item("�ܰ�", "ª�� ���� ����", swordSprite, 5, true);
        var potion = new Item("HP ����", "HP�� 50 ȸ���մϴ�", potionSprite, 0, false);

        Player.AddItem(sword);
        Player.AddItem(potion);

        UIManager.Instance.MainMenu.SetCharacterInfo(Player);
        UIManager.Instance.Status.SetCharacterInfo(Player);
        UIManager.Instance.Inventory.InitInventoryUI(Player.Inventory);

        UIManager.Instance.MainMenu.OpenMainMenu();
    }
}

