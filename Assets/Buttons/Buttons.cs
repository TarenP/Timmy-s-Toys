using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public Transform spwnLc;

    public GameObject footBall;

    public void inst()
    {
        Instantiate(footBall, spwnLc.transform.position, Quaternion.identity);
    }
}
