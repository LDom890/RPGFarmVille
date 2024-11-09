using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{

    [SerializeField] private GameObject axe;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            axe.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            axe.SetActive(false);

        }
    }
}
