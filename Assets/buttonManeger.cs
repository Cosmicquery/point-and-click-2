using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonManeger : MonoBehaviour
{
    [SerializeField] public string gameScene = "Game Scene 1";
    public void StartGame()
    {
        SceneManager.LoadScene(gameScene);
    }
}
