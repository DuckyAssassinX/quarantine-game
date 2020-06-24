using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;

    // instance
    public static GameManager instance;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
            GameUI.instance.menu.SetActive(false);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            GameUI.instance.ActivateMenu();
        }
    }

    public void AddScore(int scoreToGive)
    {
        score += scoreToGive;
    }
}
