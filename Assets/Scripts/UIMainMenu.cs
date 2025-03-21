using UnityEngine;
using UnityEngine.UI;
public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;
    //���� ���� ����
    private void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
    }
    public void OpenMainMenu()
    {
        gameObject.SetActive(true);
        UIManager.Instance.Status.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(false);
    }
    public void OpenStatus()
    {
        UIManager.Instance.Status.gameObject.SetActive(true);
        gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        UIManager.Instance.Inventory.gameObject.SetActive(true);
        gameObject.SetActive(true);
    }
}

