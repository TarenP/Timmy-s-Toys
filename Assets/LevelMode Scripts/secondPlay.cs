using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class secondPlay : MonoBehaviour
{

    public void onClick()
    {
        SceneManager.LoadScene("Instructions");
    }
}
