using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpPirate : MonoBehaviour
{
    public GameObject prefab;

    public List<GameObject> spawnedThings;
    // Start is called before the first frame update
    void Start()
    {
        spawnedThings = new List<GameObject>();

        for (int i = 0; i < 4; i++)
        {
            GameObject newThing = Instantiate(prefab, Vector3.one, Quaternion.identity);
            spawnedThings.Add(newThing);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
