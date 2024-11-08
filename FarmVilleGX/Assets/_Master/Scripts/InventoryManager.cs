using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public TextMeshProUGUI inventoryText; 
    private List<string> items = new List<string>();

    [SerializeField] private GameObject inventoryPanel;

    [SerializeField] private GameObject buttonCanvas;
    private bool inventoryActivate = false;


    private void Start()
    {
        inventoryPanel.SetActive(false);
        buttonCanvas.SetActive(false);
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !inventoryActivate)
        {
            buttonCanvas.SetActive(true);
            inventoryActivate = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inventoryActivate = false;
            buttonCanvas.SetActive(false);
        }
    }
    public void ShowInventory()
    {
        inventoryPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ReturnInventory()
    {
        inventoryPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}