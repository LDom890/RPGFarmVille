using UnityEngine;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public Canvas shopCanvas; // Arrastra el Canvas aquí en el Inspector

    private bool shopQuestionActive = false;

    public PlayerAppearance playerAppearance; 
    public InventoryManager inventoryManager; 
    public CameraManager cameraManager;

    public GameObject panelOutfit1;
    public GameObject panelOutfit2;
    public GameObject panelOutfit3;
    public GameObject panelOutfit4;
    [SerializeField] private GameObject questionPanel;
    [SerializeField] private GameObject buyPanel;
    [SerializeField] private GameObject sellPanel;
    public GameObject panelSellOutfit1;
    public GameObject panelSellOutfit2;
    public GameObject panelSellOutfit3;
    public GameObject panelSellOutfit4;

    private int playerCoins = 0;
    [SerializeField] private TextMeshProUGUI playerCoinsText;

    public GameObject panelOwnedOutfit1;
    public GameObject panelOwnedOutfit2;
    public GameObject panelOwnedOutfit3;
    public GameObject panelOwnedOutfit4;
    public GameObject defaultOutfit;






    private void Start()
    {
        shopCanvas.enabled = false;
        panelOutfit1.SetActive(false);
        panelOutfit2.SetActive(false);
        panelOutfit3.SetActive(false);
        panelOutfit4.SetActive(false);

        panelSellOutfit1.SetActive(true);
        panelSellOutfit2.SetActive(true);
        panelSellOutfit3.SetActive(true);
        panelSellOutfit4.SetActive(true);

        panelOwnedOutfit1.SetActive(true);
        panelOwnedOutfit2.SetActive(true);
        panelOwnedOutfit3.SetActive(true);
        panelOwnedOutfit4.SetActive(true);
        defaultOutfit.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !shopQuestionActive)
        {
            ShowShop();
            shopQuestionActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            shopQuestionActive = false;
        }
    }


    private void ShowShop()
    {
        shopCanvas.enabled = true; 
        Time.timeScale = 0f; 
    }

    public void HideShop()
    {
        shopCanvas.enabled = false; // Desactiva el render del Canvas
        Time.timeScale = 1f; // Restaura el tiempo
    }

    public void ShowBuyPanel()
    {
        buyPanel.SetActive(true);
        questionPanel.SetActive(false);
    }
    public void ReturnPanel0Buy()
    {
        buyPanel.SetActive(false);
        questionPanel.SetActive(true);
    }
    public void ReturnPanel0Sell()
    {
        sellPanel.SetActive(false);
        questionPanel.SetActive(true);
    }

    public void ShowSellPanel()
    {
        sellPanel.SetActive(true);
        questionPanel.SetActive(false);
    }

    public void BuyOutfit1()
    {
        //if(playerCoins >= 500)
        playerAppearance.ChangeOutfit(1);
        panelOutfit1.SetActive(true);
        inventoryManager.AddItem("Outfit1");
        cameraManager.CheckPlayer();
        panelSellOutfit1.SetActive(false);
        panelOwnedOutfit1.SetActive(false);

    }

    public void BuyOutfit2()
    {
        //if (playerCoins >= 1000)
        playerAppearance.ChangeOutfit(2);
        panelOutfit2.SetActive(true);
        inventoryManager.AddItem("Outfit2");
        cameraManager.CheckPlayer();
        panelSellOutfit2.SetActive(false);
        panelOwnedOutfit2.SetActive(false);


    }

    public void BuyOutfit3()
    {
        //if (playerCoins >= 1500)
        playerAppearance.ChangeOutfit(3);
        panelOutfit3.SetActive(true);
        inventoryManager.AddItem("Outfit3");
        cameraManager.CheckPlayer();
        panelSellOutfit3.SetActive(false);
        panelOwnedOutfit3.SetActive(false);


    }

    public void BuyOutfit4()
    {
        //if (playerCoins >= 2000)
        playerAppearance.ChangeOutfit(4);
        panelOutfit4.SetActive(true);
        inventoryManager.AddItem("Outfit4");
        cameraManager.CheckPlayer();
        panelSellOutfit4.SetActive(false);
        panelOwnedOutfit4.SetActive(false);


    }

    public void UpdateCanvas()
    {
        playerCoinsText.text = playerCoins.ToString();
    }
    public void SellOutfit1()
    {
        playerAppearance.ChangeOutfit(default);
        panelOutfit1.SetActive(false);
        inventoryManager.AddItem("Outfit1");
        cameraManager.CheckPlayer();
        panelSellOutfit1.SetActive(true);
        panelOwnedOutfit1.SetActive(true);


    }

    public void SellOutfit2()
    {
        playerAppearance.ChangeOutfit(default);
        panelOutfit2.SetActive(false);
        inventoryManager.AddItem("Outfit2");
        cameraManager.CheckPlayer();
        panelSellOutfit2.SetActive(true);
        panelOwnedOutfit2.SetActive(true);


    }
    public void SellOutfit3()
    {
        playerAppearance.ChangeOutfit(default);
        panelOutfit3.SetActive(false);
        inventoryManager.AddItem("Outfit3");
        cameraManager.CheckPlayer();
        panelSellOutfit3.SetActive(true);
        panelOwnedOutfit3.SetActive(true);

    }
    public void SellOutfit4()
    {
        playerAppearance.ChangeOutfit(default);
        panelOutfit4.SetActive(false);
        inventoryManager.AddItem("Outfit4");
        cameraManager.CheckPlayer();
        panelSellOutfit4.SetActive(true);
        panelOwnedOutfit4.SetActive(true);

    }





    public void PlayerSelectOutfit1()
    {
        playerAppearance.ChangeOutfit(1);
        panelOutfit1.SetActive(false);
        inventoryManager.AddItem("Outfit1");
        cameraManager.CheckPlayer();
        panelSellOutfit1.SetActive(false);
        panelOwnedOutfit1.SetActive(false);
    }

    public void PlayerSelectOutfit2()
    {
        playerAppearance.ChangeOutfit(2);
        panelOutfit2.SetActive(false);
        inventoryManager.AddItem("Outfit2");
        cameraManager.CheckPlayer();
        panelSellOutfit2.SetActive(false);
        panelOwnedOutfit2.SetActive(false);

    }
    public void PlayerSelectOutfit3()
    {
        playerAppearance.ChangeOutfit(3);
        panelOutfit3.SetActive(false);
        inventoryManager.AddItem("Outfit3");
        cameraManager.CheckPlayer();
        panelSellOutfit3.SetActive(false);
        panelOwnedOutfit3.SetActive(false);

    }
    public void PlayerSelectOutfit4()
    {
        playerAppearance.ChangeOutfit(4);
        panelOutfit4.SetActive(false);
        inventoryManager.AddItem("Outfit4");
        cameraManager.CheckPlayer();
        panelSellOutfit4.SetActive(false);
        panelOwnedOutfit4.SetActive(false);

    }

    public void PlayerSelectDefaultOutfit()
    {
        playerAppearance.ChangeOutfit(default);
        panelOutfit4.SetActive(true);
        inventoryManager.AddItem("Outfit4");
        cameraManager.CheckPlayer();
        panelSellOutfit4.SetActive(false);
        panelOwnedOutfit4.SetActive(false);

    }
}