using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue : MonoBehaviour
{
    GameObject blue_cube;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        blue_cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        blue_cube.transform.localScale += new Vector3(4, 1, 0);
        blue_cube.GetComponent<Renderer>().material.color = Color.blue;
        blue_cube.transform.position = new Vector3(0, -15, 55);
    }

    // Update is called once per frame
    void Update()
    {
        blue_cube.transform.position += new Vector3(0f, 0f, speed * Time.deltaTime * (-1));
    }
}
