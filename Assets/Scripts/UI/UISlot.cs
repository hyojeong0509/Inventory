using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image iconImage;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI descriptionText;

    [SerializeField] private TextMeshProUGUI equipStateText; //장착 텍스트
    private Item item;

    public void SetItem(Item newItem)
    {
        item = newItem;
        RefreshUI();

        GetComponent<Button>().onClick.AddListener(OnClickSlot);
    }
    private void OnClickSlot()
    {
        Debug.Log($"슬롯 클릭됨: {item.Name} / 현재 장착 상태: {item.IsEquipped}");
        item.ToggleEquip();
        Debug.Log($"장착 상태 변경됨 → {item.IsEquipped}");
        RefreshUI();

        UIManager.Instance.Status.RefreshUI();
    }
    private void RefreshUI()
    {
        if (item == null)
        {
            Debug.LogWarning("item이 null입니다.");
            return;
        }
        if (nameText == null)
            Debug.LogError("nameText가 null입니다!");
        if (descriptionText == null) 
            Debug.LogError("descriptionText가 null입니다!");
        if (iconImage == null)
            Debug.LogError("iconImage가 null입니다!");

        iconImage.sprite = item.Icon;
        nameText.text = item.Name;
        descriptionText.text = item.Description;

        equipStateText.text = item.IsEquipped ? "E" : "";
    }
}
