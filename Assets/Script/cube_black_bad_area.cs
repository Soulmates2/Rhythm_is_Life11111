using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_black_bad_area : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("on trigger stay");
        if (Input.GetKey(KeyCode.F)&&other.tag== "black")
        {
            Score_Manager.score += 5;
            other.tag = "destroy";
        }
    }
}
