using UnityEngine;
using System.Collections;

public class SetNextDestination : MonoBehaviour { //moves an object to a point

	public Transform direction;   //set this to the left eye of the MR Camera 

	private NavMeshAgent agent;

	// Use this for initialization
	void Start () 
	{
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) //when a key is pressed the agent moves
		{
			RaycastHit hit;
			if (Physics.Raycast(direction.position, direction.forward, out hit)) 
			{
				agent.SetDestination(hit.point);
				agent.updateRotation = false;
			}
		}
	}
}
