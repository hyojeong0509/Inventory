using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI attackText;
    [SerializeField] private TextMeshProUGUI shieldText;
    [SerializeField] private TextMeshProUGUI criticalText;

    [SerializeField] private Button returnButton;

    private Character character;
    private void Start()
    {
        returnButton.onClick.AddListener(CloseStatus);
    }
    public void SetCharacterInfo(Character character)
    {
        Debug.Log("Status 캐릭터 정보 세팅됨!");

        this.character = character;
        RefreshUI();
    }
    public void RefreshUI()
    {
        hpText.text = $"{character.HP}";
        attackText.text = $"{character.GetTotalAttack()}";
        shieldText.text = $"{character.Shield}";
        criticalText.text = $"{character.Critical}";
    }

    public void CloseStatus()
    {
        gameObject.SetActive(false);
        UIManager.Instance.MainMenu.OpenMainMenu();
    }
}

