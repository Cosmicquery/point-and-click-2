using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonManeger : MonoBehaviour
{
    //ville göra en array med scener, men den ville inte samarbeta
    [SerializeField] public string gameScene = ("Game Scene 1");
    [SerializeField] public string MenuScene = ("Menu scene");
    public void StartGame()
    {
        SceneManager.LoadScene(gameScene);
    }
    public void StopGame()
    {
        SceneManager.LoadScene(MenuScene);
    }
}
