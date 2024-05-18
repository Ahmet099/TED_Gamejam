using UnityEngine;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    public TextMeshProUGUI elapsedTimeText;

    void Start()
    {
        Cursor.visible = true; // Fare imleci g�r�n�r hale getiriliyor
        Cursor.lockState = CursorLockMode.None; // Fare imleci kilidi kald�r�l�yor

        // Timer s�n�f�ndaki elapsedTime de�i�kenine eri�erek ge�en s�reyi al
        float elapsedTime = Timer.elapsedTime;

        // Ge�en s�reyi metin nesnesine atayarak g�ster
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        elapsedTimeText.text = "Oyunda gecirdiginiz sure: " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
