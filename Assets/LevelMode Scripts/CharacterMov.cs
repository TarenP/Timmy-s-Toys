using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMov : MonoBehaviour
{
    public GameObject[] Projectiles;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(Projectiles[0], transform.position, Quaternion.identity);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Instantiate(Projectiles[1], transform.position, Quaternion.identity);
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(Projectiles[2], transform.position, Quaternion.identity);
            
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == gameObject.tag)
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
        }
    }
}
