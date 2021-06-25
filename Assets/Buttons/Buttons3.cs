using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons3 : MonoBehaviour
{
    public Transform spwnLc;

    public GameObject footBall;

    public void inst1()
    {
        Debug.Log("Pressed");
        Instantiate(footBall, spwnLc.transform.position, Quaternion.identity);
    }
}
