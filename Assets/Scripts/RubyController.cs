using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public float vel = 3;
    public int health = 5;
    public int max_health = 5;

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.x += Input.GetAxis("Horizontal") * Time.deltaTime * vel;
        position.y += Input.GetAxis("Vertical") * Time.deltaTime * vel;
        transform.position = position;
    }

    public void updateHealth(int value)
    {
        health += Mathf.Clamp(value, 0, max_health);
    }
}
