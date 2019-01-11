using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow : MonoBehaviour
{
    GameObject yellow_cube;
    public float speed = 1f;
    // Start is called before the first frame updte
    void Start()
    {
        yellow_cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        yellow_cube.transform.localScale += new Vector3(4, 1, 0);
        yellow_cube.GetComponent<Renderer>().material.color = Color.yellow;
        yellow_cube.transform.position = new Vector3(10, -15, 55);
    }

    // Update is called once per frame
    void Update()
    {
        yellow_cube.transform.position += new Vector3(0f, 0f, speed * Time.deltaTime * (-1));
    }
}
