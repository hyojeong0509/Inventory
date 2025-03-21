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

        UIManager.Instance.MainMenu.SetCharacterInfo(Player);
        UIManager.Instance.Status.SetCharacterInfo(Player);

        UIManager.Instance.MainMenu.OpenMainMenu();
    }
}

