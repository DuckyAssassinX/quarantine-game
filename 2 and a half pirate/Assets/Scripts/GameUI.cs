using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public GameObject menu;

    // instance
    public static GameUI instance;

    private void Awake()
    {
        instance = this;
        menu.SetActive(false);
    }

     public void ActivateMenu()
    {
        
            if (!menu.activeSelf)
            {
                menu.SetActive(true);
            }
            else
            {
                menu.SetActive(false);
            }
        
    }

    public void OnReturnButton()
    {
        menu.SetActive(false);
    }

    public void OnCloseButton()
    {

    }


}
