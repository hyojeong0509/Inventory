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
        Player = new Character("È¿Á¤", 2, 100, 20, 10, 15);

        UIManager.Instance.Status.SetCharacterInfo(Player);
    }
}

