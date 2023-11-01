using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    [SerializeField] Vector2 flyForce = new Vector2(0, 300);

    Rigidbody2D rb2D;


    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();
        }
    }

    private void Die()
    {
        SaveManager.instance.SaveUserHighScore(Score.score);
        SaveManager.instance.SaveData(Score.score);
        PlayerPrefs.DeleteKey("username");
        Score.score = 0;
        SceneManager.LoadScene(0);
    }

    public void OnFly()
    {
        rb2D.velocity = Vector2.zero;

        rb2D.AddForce(flyForce);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Die();
    }
}
