using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // gets called evry time we click on our bird
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }
}