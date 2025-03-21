using UnityEngine;
public class UIManager : MonoBehaviour
{
   public static UIManager Instance { get; private set; }

    [SerializeField] private UIMainMenu uiMainMenu;
    [SerializeField] private UIStatus uiStatus;
    [SerializeField] private UIInventory uiInventory; 

    public UIMainMenu MainMenu => uiMainMenu;
    public UIStatus Status => uiStatus;
    public UIInventory Inventory => uiInventory;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }
}

