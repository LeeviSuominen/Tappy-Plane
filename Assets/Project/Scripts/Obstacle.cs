using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] Vector2 obstacleVelocity = new Vector2(-3, 0);

    float range = 2f;

    private void Start() {
        GetComponent<Rigidbody2D>().velocity = obstacleVelocity;

        float y = Random.Range(-range, range);
        transform.position = new Vector2(transform.position.x, y);
    }
}
