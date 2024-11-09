using UnityEngine;

public class Tree : MonoBehaviour
{
    public int treeHealth = 100;
    public int damagePerHit = 25;

    [SerializeField] private GameObject treeGameObject;

    public ShopManager shopManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
        {
            treeHealth -= damagePerHit;

            if (treeHealth <= 0)
            {
                treeGameObject.SetActive(false);
                shopManager.AddCoins();

            }
        }
    }

    
}