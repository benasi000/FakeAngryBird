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

    //when mouse moves of the object(the green bird) it restores it color
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    //ment for draging the bird to sling shot it
    private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y);
    }
}
