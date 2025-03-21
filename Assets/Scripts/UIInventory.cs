using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button returnButton; // 뒤로가기 버튼 추가

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
