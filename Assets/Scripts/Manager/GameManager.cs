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

        UIManager.Instance.MainMenu.SetCharacterInfo(Player);
        UIManager.Instance.Status.SetCharacterInfo(Player);

        UIManager.Instance.MainMenu.OpenMainMenu();
    }
}

