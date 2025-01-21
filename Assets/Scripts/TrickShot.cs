using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TrickShot : MonoBehaviour
{
    float speed;
    public AnimationCurve jump;
    public AnimationCurve spin;

    public float t;
    bool jumping = false;
    bool timer = true;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 rot = transform.eulerAngles;
        pos.x += speed;

       if (Input.GetKeyDown(KeyCode.Space) && jumping == false)
       {
            timer = true;
       }

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speed *= -1;
        }

        if(timer)
        {
            t += Time.deltaTime;
            pos.y = jump.Evaluate(t);
            rot.z = spin.Evaluate(t);
            if (t > 1)
            {
                timer = false;
                t = 0;
            }

        }

        transform.eulerAngles = rot;
        transform.position = pos;

    }
}
