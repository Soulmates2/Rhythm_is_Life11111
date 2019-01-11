using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red : MonoBehaviour
{
    GameObject red_cube;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        red_cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        red_cube.transform.localScale += new Vector3(4, 1, 0);
        red_cube.GetComponent<Renderer>().material.color = Color.red;
        red_cube.transform.position = new Vector3(-10, -15, 30);
    }

    // Update is called once per frame
    void Update()
    {
        if (red_cube != null)
        {
            red_cube.transform.position += new Vector3(0f, 0f, speed * Time.deltaTime * (-1));
            if (Input.GetKey(KeyCode.A)) Destroy(red_cube);
        }
    }
}
