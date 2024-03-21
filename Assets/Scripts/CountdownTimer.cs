using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float totalTime = 60f;
    private float currentTime;

    private bool isTimerRunning = false;

    private void Start()
    {
        currentTime = totalTime;
        isTimerRunning = true;

        StartCoroutine(StartTimer());
    }

    private IEnumerator StartTimer()
    {
        while (currentTime > 0 && isTimerRunning)
        {
            timerText.text = Mathf.RoundToInt(currentTime).ToString();

            yield return new WaitForSeconds(1f);

            currentTime -= 1f;
        }

        // Check if the timer reached zero and the game is still running
        if (currentTime <= 0 && isTimerRunning)
        {
            // Display message
            timerText.text = "Time's up!";
            
            // Stop the game or perform other actions
            GameOver();
        }
    }

    public void GameOver()
    {
        isTimerRunning = false;
        Time.timeScale = 0f;
        Debug.Log("Game Over");


    }
}
