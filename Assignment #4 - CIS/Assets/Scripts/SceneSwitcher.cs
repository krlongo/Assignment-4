/*
     * Kevon Long
     * SceneSwitcher.cs
     * Assignment #4
     * Switches Scenes
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    public static void Lose()
    {
        SceneManager.LoadScene("LoseScene");
    }

}
