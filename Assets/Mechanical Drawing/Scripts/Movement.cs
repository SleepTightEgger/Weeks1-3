using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public AnimationCurve curve;
    public AnimationCurve curve2;
    public float t;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        t += Time.deltaTime;

        if (t > 1)
        {
            t = 0;
        }

        Vector3 pos = transform.position;
        pos.x = curve.Evaluate(t);
        pos.y = curve2.Evaluate(t);

        transform.position = pos;
    }
}
