﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("QUIT");
        SceneManager.LoadScene(0);
    }
}
