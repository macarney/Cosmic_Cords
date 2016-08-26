using UnityEngine;
using System.Collections;

public class LaserPointer : MonoBehaviour
{

    GameObject hitObject;           //store the object that the raycast has hit
    RaycastHit hit;                 //stores data related to the hit
		
	void Update ()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))         //gives you the fwd direction of the object this script is attached to
        {
            hitObject = hit.transform.gameObject;
            Interactable interactable = hitObject.GetComponent<Interactable>();
            if (interactable != null)
            {
                interactable.targetted = true;
            }
        }
	}
}
