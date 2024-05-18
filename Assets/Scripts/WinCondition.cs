using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Eðer temas eden nesne etiketi "Player" ise
        {
            SceneManager.LoadScene(3); // Kazandýnýz sahnesini yükle
        }
    }
}
