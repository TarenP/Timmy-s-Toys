using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Timer1 : MonoBehaviour
{
    [SerializeField]
    private string levelToLoad;

    [SerializeField]
    private float delayBeforeLoading = 60f;

    private float timeElapsed;

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    
    }
    
}
