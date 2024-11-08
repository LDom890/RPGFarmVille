using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private Camera mainCamera; // Referencia de la cámara, asignada desde el Inspector
    public float followDelay = 0.5f; // Tiempo de retraso para seguir al jugador
    private Transform playerTransform;


    private void Awake()
    {
        CheckPlayer();
    }
    public void CheckPlayer()
    {
        if (playerTransform == null || !playerTransform.gameObject.activeInHierarchy)
        {
            // Intenta encontrar el jugador nuevamente si no hay uno asignado o el actual está inactivo
            PlayerMovement player = FindObjectOfType<PlayerMovement>();
            if (player != null && player.gameObject.activeInHierarchy)
            {
                playerTransform = player.transform;
                Debug.Log("Player encontrado: " + player.gameObject.name);
            }
        }
    }


    private void LateUpdate()
    {
        if (playerTransform != null && mainCamera != null)
        {
            // Interpola la posición de la cámara hacia la posición del jugador con un ligero retraso
            Vector3 targetPosition = new Vector3(playerTransform.position.x, playerTransform.position.y, mainCamera.transform.position.z);
            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, targetPosition, followDelay * Time.deltaTime);
        }
    }
}