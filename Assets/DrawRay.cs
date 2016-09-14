using UnityEngine;
using System.Collections;

public class DrawRay : MonoBehaviour {

    public int rayLength = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 forward = transform.TransformDirection(Vector3.forward) * rayLength;
        Debug.DrawRay(transform.position, forward, Color.green);

    }
}
