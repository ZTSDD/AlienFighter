﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBtnController : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenuScene", LoadSceneMode.Single);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
