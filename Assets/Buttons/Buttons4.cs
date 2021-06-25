using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons4 : MonoBehaviour
{
    public Transform spwnLc;

    public GameObject basket;

    public void insta2()
    {
        Instantiate(basket, spwnLc.transform.position, Quaternion.identity);
    }
}
