using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        RubyController contoller = collision.GetComponent<RubyController>();
        Debug.Log("colidiu");
        if (contoller != null)
        {
            Debug.Log("colidiu vida");
            contoller.updateHealth(1);
            Destroy(gameObject);
        }
    }
}
