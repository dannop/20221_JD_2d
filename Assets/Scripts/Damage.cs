using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float max_time = 4;
    private float time = 0;

    private void OnTriggerStay2D(Collider2D collision)
    {
        RubyController controller = collision.GetComponent<RubyController>();
        
        if (controller != null && controller.health > 0)
        {
            time += Time.deltaTime;
            if (time >= max_time)
            {
                controller.updateHealth(-1);
                time = 0;
            }
        }
    }
}
