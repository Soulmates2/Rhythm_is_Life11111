﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_black_good_area : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey(KeyCode.F) && other.tag == "black")
        {
            Debug.Log("ggg");
            Score_Manager.score += 10;
            Destroy(other.gameObject);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("on trigger stay");
        if (Input.GetKey(KeyCode.F) && other.tag == "black")
        {
            Debug.Log("ggg");
            Score_Manager.score += 10;
            Destroy(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (Input.GetKey(KeyCode.F) && other.tag == "black")
        {
            Debug.Log("ggg");
            Score_Manager.score += 10;
            Destroy(other.gameObject);
        }
    }
}
