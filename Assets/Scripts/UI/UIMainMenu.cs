using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    [SerializeField] private TextMeshProUGUI classText;
    [SerializeField] private TextMeshProUGUI classexplainText;
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;

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
    public void SetCharacterInfo(Character character)
    {
        Debug.Log("MainMenu 캐릭터 정보 세팅됨!");

        classText.text = character.Job;
        classexplainText.text = character.JobExplain;
        coinText.text = "10000";
        nameText.text = character.Name;
        levelText.text = $"Lv. {character.Level}";
    }
}

