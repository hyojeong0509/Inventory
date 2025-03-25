using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image iconImage;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI descriptionText;

    private Item item;

    public void SetItem(Item newItem)
    {
        item = newItem;
        RefreshUI();
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
    }
}
