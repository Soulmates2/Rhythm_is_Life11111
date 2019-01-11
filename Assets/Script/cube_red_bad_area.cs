using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_red_bad_area : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("on trigger stay");
        if (Input.GetKey(KeyCode.A)&&other.tag=="red")
        {
            Score_Manager.score += 5;
            other.tag = "destroy";
        }
    }
}
