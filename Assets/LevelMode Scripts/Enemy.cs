using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed;
   

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
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
