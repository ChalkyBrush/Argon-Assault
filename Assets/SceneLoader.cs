﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadLevel1", 2);
    }

    // Update is called once per frame
    void LoadLevel1()
    {
        SceneManager.LoadScene(1);
    }
}
