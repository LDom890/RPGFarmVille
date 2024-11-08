using UnityEngine;

public class PlayerAppearance : MonoBehaviour
{
    [SerializeField] private GameObject defaultOutfit;
    [SerializeField] private GameObject outfit1;
    [SerializeField] private GameObject outfit2;
    [SerializeField] private GameObject outfit3;
    [SerializeField] private GameObject outfit4;

    private GameObject currentOutfit;

    private void Start()
    {
        SetActiveOutfit(defaultOutfit);
    }

    public void ChangeOutfit(int outfitNumber)
    {
        switch (outfitNumber)
        {
            case 1:
                SetActiveOutfit(outfit1);
                break;
            case 2:
                SetActiveOutfit(outfit2);
                break;
            case 3:
                SetActiveOutfit(outfit3);
                break;
            case 4:
                SetActiveOutfit(outfit4);
                break;
            default:
                SetActiveOutfit(defaultOutfit);
                break;
        }
    }

    private void SetActiveOutfit(GameObject newOutfit)
    {
        // Desactiva el atuendo actual si hay uno activo
        if (currentOutfit != null)
        {
            currentOutfit.SetActive(false);
        }

        // Activa el nuevo atuendo y actualiza el atuendo actual
        newOutfit.SetActive(true);
        currentOutfit = newOutfit;
    }
}