using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public TextMeshProUGUI inventoryText; 
    private List<string> items = new List<string>();

    [SerializeField] private GameObject InventoryPanel;



    private void Start()
    {
        InventoryPanel.SetActive(false);
    }
    public void AddItem(string itemName)
    {
        if (!items.Contains(itemName))
        {
            items.Add(itemName);
            UpdateInventoryUI();
        }
    }
    public void RemoveItem(string itemName)
    {
        if (!items.Contains(itemName))
        {
            items.Add(itemName);
            UpdateInventoryUI();
        }
    }

    private void UpdateInventoryUI()
    {
        inventoryText.text = "Inventario:\n";
        foreach (string item in items)
        {
            inventoryText.text += item + "\n";
        }
    }

    public void ShowInventory()
    {
        InventoryPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ReturnInventory()
    {
        InventoryPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}