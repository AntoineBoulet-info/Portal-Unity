using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacerObjet : MonoBehaviour
{
    public GameObject tempParent;
    public Transform guide;

    void Update() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 4))
        {
            if (Input.GetMouseButtonDown(1))
            {
                EnterAction(hit.collider.gameObject);
            }
            if (Input.GetMouseButtonUp(1))
            {
                ExitAction(hit.collider.gameObject);
            }
        }
        
    }
    void EnterAction(GameObject objet) {
        objet.GetComponent<Rigidbody>().useGravity = false;
        objet.GetComponent<Rigidbody>().isKinematic = true;
        objet.transform.position = guide.transform.position;
        objet.transform.rotation = guide.transform.rotation;
        objet.transform.parent = tempParent.transform;
    }

    private void ExitAction(GameObject objet) {
        objet.GetComponent<Rigidbody>().useGravity = true;
        objet.GetComponent<Rigidbody>().isKinematic = false;
        objet.transform.parent = null;
        objet.transform.position = guide.transform.position;
    }
}
