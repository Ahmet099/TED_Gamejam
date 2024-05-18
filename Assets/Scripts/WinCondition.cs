using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // E�er temas eden nesne etiketi "Player" ise
        {
            SceneManager.LoadScene(3); // Kazand�n�z sahnesini y�kle
        }
    }
}
