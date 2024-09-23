using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    public float speed = 2f;
    public GameObject Obstacle;
    public int height;
    public int width = 5;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < -10f) Destroy(gameObject);
    }
}
