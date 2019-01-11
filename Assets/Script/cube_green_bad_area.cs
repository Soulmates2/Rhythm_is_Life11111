using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_green_bad_area : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("on trigger stay");
        if (Input.GetKey(KeyCode.S)&&other.tag== "green")
        {
            Score_Manager.score += 5;
            other.tag = "destroy";
        }
    }
}
