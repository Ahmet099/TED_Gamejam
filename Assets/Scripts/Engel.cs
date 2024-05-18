using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Engel : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Check if the player collided with an obstacle
        if (collision.gameObject.CompareTag("Obstacle"))
        {

            SceneManager.LoadScene(2);


            // Handle obstacle collision here (e.g., reduce player health, play sound, etc.)
            Debug.Log("Hit obstacle!");
        }
    }
}
