using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button returnButton;

    private void Start()
    {
        returnButton.onClick.AddListener(CloseInventory);
    }

    public void CloseInventory()
    {
        gameObject.SetActive(false);
        UIManager.Instance.MainMenu.OpenMainMenu();
    }
}
