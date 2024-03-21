using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject panelprefab;

    public void Awake()
    {
        panelprefab = GameObject.FindGameObjectWithTag("PauseTag");
        panelprefab.SetActive(false);
    }

    public void activePausePanel()
    {
        panelprefab.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resumeGame()
    {
        panelprefab.SetActive(false);
        Time.timeScale = 1f;
    }

    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }
}
