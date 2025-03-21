using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI attackText;
    [SerializeField] private TextMeshProUGUI shieldText;
    [SerializeField] private TextMeshProUGUI criticalText;


    [SerializeField] private Button returnButton;
    private void Start() 
    {
        returnButton.onClick.AddListener(CloseStatus);
    }
    public void SetCharacterInfo(Character character)
    {
        nameText.text = $"{character.Name}";
        levelText.text = $"Lv. {character.Level}";
        hpText.text = $"{character.HP}";
        attackText.text = $"{character.Attack}";
        shieldText.text = $"{character.Shield}";
        criticalText.text = $"{character.Critical}";
    }
    public void CloseStatus()
    {
        gameObject.SetActive(false);
        UIManager.Instance.MainMenu.OpenMainMenu();
    }
}

