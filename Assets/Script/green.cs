using UnityEngine;

public class green : MonoBehaviour
{
    GameObject green_cube;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        green_cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        green_cube.transform.localScale += new Vector3(4, 1, 0);
        green_cube.GetComponent<Renderer>().material.color = Color.green;
        green_cube.transform.position = new Vector3(-5, -15, 80);
    }

    // Update is called once per frame
    void Update()
    {
        green_cube.transform.position += new Vector3(0f, 0f, speed * Time.deltaTime * (-1));
    }
}
