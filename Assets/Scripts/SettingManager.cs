using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingManager : MonoBehaviour
{
    public GameObject panelprefab;

    public void Awake()
    {
        panelprefab = GameObject.FindGameObjectWithTag("SettingTag");
        panelprefab.SetActive(false);
    }

    public void activeSettingPanel()
    {
        panelprefab.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resumeGame()
    {
        panelprefab.SetActive(false);
        Time.timeScale = 1f;
    }
}
