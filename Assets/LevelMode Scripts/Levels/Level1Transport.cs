﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Transport : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene("Main 1.5");
    }
}
