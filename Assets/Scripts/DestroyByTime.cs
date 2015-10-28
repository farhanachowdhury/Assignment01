/*Created by: Farhana Chowdhury
 Student ID: 300812011
 Source: Unity Space shooter Tutorial Video.
 This class was built to provide the method to destroy the gameobject after the intended time  */
using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
{
    public float lifetime;
    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
