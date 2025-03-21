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
        if (item != null)
        {
            iconImage.sprite = item.Icon;
            nameText.text = item.Name;
            descriptionText.text = item.Description;
        }
    }
}
