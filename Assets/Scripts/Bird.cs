using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Vector2 startPos;
    private void Start()
    {
        startPos = transform.position;
    }
    private void OnMouseDrag()
    {
        Vector2 p = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float radius = 1.8f;
        Vector2 dir = p - startPos;
        if (dir.sqrMagnitude > radius)
        {
            dir = dir.normalized * radius;
            transform.position = startPos + dir;
        }
    }

}
