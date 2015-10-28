/*Created by: Farhana Chowdhury
 Student ID: 300812011
 Date:10/04/2015
 Source: Unity Space shooter Tutorial Video.
 This class was built to provide the method for the hazards speed. */
using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float speed;
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
}
