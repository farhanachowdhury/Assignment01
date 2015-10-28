/*Created by: Farhana Chowdhury
 Student ID: 300812011
 Source: Unity Space shooter Tutorial Video.
 This class was built to provide the method to avoid the hazards of takign up space by exploisions  */
using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour 
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
