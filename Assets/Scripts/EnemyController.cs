using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float vel = 2;
    public float change_time = 2;
    public bool is_vertical = false;

    Animator animator;

    private int direction = 1;
    private float time = 0;

    private void ChangeDirection()
    {
        time += Time.deltaTime;
        if (time >= change_time)
        {
            direction = -direction;
            time = 0;
        }
    }

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        ChangeDirection();
        Vector2 position = transform.position;
        if (is_vertical)
        {
            animator.SetFloat("dirX", 0);
            animator.SetFloat("dirY", direction);
            position.y += Time.deltaTime * vel * direction;
        } 
        else
        {
            animator.SetFloat("dirX", direction);
            animator.SetFloat("dirY", 0);
            position.x += Time.deltaTime * vel * direction;
        }
        transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        RubyController controller = collision.gameObject.GetComponent<RubyController>();
        if (controller != null && controller.health > 0)
        {
            controller.updateHealth(-1);
        }
    }
}
