using UnityEngine;
using System.Collections;

public class TriggerByLooking : MonoBehaviour {  //changes a color of an object when it is looked at this is currently on the balls.
												 // currently using this to test when an object knows it is seen / unseen.

	public Transform direction;					 //Make this the left eye of the MR camera.

	private int maxHitDistnace = 100;
	ChangeMaterial changeMaterial;
	private bool selecting = false;
	private GameObject lastObject;
	
	// Update is called once per frame
	void Update () 
	{
		CheckHit ();
	}

	private void CheckHit()
	{
		RaycastHit hit;
		if (Physics.Raycast(direction.position, direction.forward, out hit, maxHitDistnace))
		{
			if (hit.collider.gameObject.tag.Equals("Gaze"))
			{
				if (lastObject != null && !hit.collider.gameObject.Equals (lastObject)) 
				{
					Deselect ();
				}
				if (!selecting) 
				{
					Select (hit.collider.gameObject);
				}} else {
					
					if (selecting) //hit normal object without the "Gaze" tag
					{
						Deselect();
					} else 
					{
						Deselect(); // nothing is selected
					}
				}
			}

	}
	
	private void Select(GameObject hitObject)   //when hit by the raycast change color to blue
	{
		selecting = true;
		changeMaterial = hitObject.GetComponent<ChangeMaterial>();
		changeMaterial.ChangeTo ("blue");
		lastObject = hitObject;
	}

	private void Deselect() //when NOT hit by the raycast change color to red
	{
		selecting = false;
		if (changeMaterial != null)
		{
			changeMaterial.ChangeTo ("red");
		}
	}
}
