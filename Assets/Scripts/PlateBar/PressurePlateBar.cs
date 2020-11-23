using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateBar : MonoBehaviour
{
    public GameObject Bar;

    void OnTriggerEnter(Collider other) 
    {
        Bar.transform.Rotate(Vector3.up * 90f);
    }
    void OnTriggerExit(Collider other) 
    {
        Bar.transform.Rotate(Vector3.up * 90f);
    }
}
