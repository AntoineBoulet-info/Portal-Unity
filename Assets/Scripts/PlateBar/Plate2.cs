using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate2 : MonoBehaviour
{
    public GameObject Bar;
    public GameObject Bar2;

    void OnTriggerEnter(Collider other) 
    {
        Bar.transform.Rotate(Vector3.up * 90f);
        Bar2.transform.Rotate(Vector3.up * 90f);

    }
    void OnTriggerExit(Collider other) 
    {
        Bar.transform.Rotate(Vector3.up * 90f);
        Bar2.transform.Rotate(Vector3.up * 90f);
    }
}
