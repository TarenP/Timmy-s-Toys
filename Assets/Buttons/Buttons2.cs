using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons2 : MonoBehaviour
{
    public Transform spwnLc;

    public GameObject socc;

    public void instan()
    {
        Instantiate(socc, spwnLc.transform.position, Quaternion.identity);
    }
}
