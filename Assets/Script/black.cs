using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class black : MonoBehaviour
{
    GameObject black_cube;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        black_cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        black_cube.transform.localScale += new Vector3(4, 1, 0);
        black_cube.GetComponent<Renderer>().material.color = Color.black;
        black_cube.transform.position = new Vector3(5, -15, 30);
    }

    // Update is called once per frame
    void Update()
    {
        black_cube.transform.position += new Vector3(0f, 0f, speed * Time.deltaTime * (-1));
    }
}
