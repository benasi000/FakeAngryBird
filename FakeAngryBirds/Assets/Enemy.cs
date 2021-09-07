using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bird bird = collision.collider.GetComponent<Bird>();

        if (bird != null)
        {
            Destroy(gameObject);
        }
    }
}
