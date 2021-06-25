using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy1 : MonoBehaviour
{
    public float speed1;
   

    void Update()
    {
        transform.Translate(Vector2.left * speed1 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == gameObject.tag)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else
        {
            SceneManager.LoadScene("You lost");
        }
    }
}
