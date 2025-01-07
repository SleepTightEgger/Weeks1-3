using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speed *= -1;
        }

        transform.position = pos;

    }
}
