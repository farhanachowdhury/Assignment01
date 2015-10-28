/*Created by: Farhana Chowdhury
 Student ID: 300812011
 Date:10/04/2015
 Source: Unity Space shooter Tutorial Video.
 This class was built to provide the method for the hazards' angular movement. */
using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    public float tumble;
    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }
}
