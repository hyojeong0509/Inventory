using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using static UnityEditor.Progress;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button returnButton;

    [SerializeField] private Transform slotParent; // 슬롯이 붙을 부모 (스크롤 뷰 Content)
    [SerializeField] private GameObject slotPrefab; 

    private void Start()
    {
        returnButton.onClick.AddListener(CloseInventory);
    }

    private List<UISlot> slotList = new List<UISlot>();

    public void InitInventoryUI(List<Item> items)
    {
        foreach (Transform child in slotParent)
        {
            Destroy(child.gameObject);
        }

        slotList.Clear();

        foreach (var item in items)
        {
            var slotGO = Instantiate(slotPrefab, slotParent);
            var slot = slotGO.GetComponent<UISlot>();
            slot.SetItem(item);
            slotList.Add(slot);
        }
    }
    public void CloseInventory()
    {
        gameObject.SetActive(false);
        UIManager.Instance.MainMenu.OpenMainMenu();
    }
}
