using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons5 : MonoBehaviour
{
    public Transform spwnLc;

    public GameObject socc;

    public void instan3()
    {
        Instantiate(socc, spwnLc.transform.position, Quaternion.identity);
    }
}
