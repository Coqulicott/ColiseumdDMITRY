﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void QuitGame()                                    // Quitter le jeu
    {
        Debug.Log("Vous avez quitte le jeu !");
        Application.Quit();
    }

}
