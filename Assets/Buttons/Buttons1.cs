using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons1 : MonoBehaviour
{
    public Transform spwnLc;

    public GameObject basket;

    public void insta()
    {
        Instantiate(basket, spwnLc.transform.position, Quaternion.identity);
    }
}
