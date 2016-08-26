using UnityEngine;
using System.Collections;

public class ShowDestinationPoint : MonoBehaviour // puts an object at the point a raycast is hitting 
{

	public GameObject destinationPoint;   //this is the object that will show up, suggest using a sphere or cube.
	public Transform direction;
	
	void Update () 
	{
		RaycastHit hit;
		if (Physics.Raycast(direction.position, direction.forward, out hit)) 
		{
			destinationPoint.transform.position = hit.point;
		}
	}
}
