using UnityEngine;
using System.Collections;

public class TriggerByLooking : MonoBehaviour {  //changes a color of an object when it is looked at 
												 // currently using this to test when an object knows it is seen / unseen.

	public Transform rayObjectDir; 
	public int maxHitDistnace = 1000;

	private ChangeMaterial changeMaterial;	//tells this object to change colors if it is selected
	private GameObject  lastObject;   
    private AudioSource audioSource;        

    public bool isSelected = false;
    public bool isPlayingCord = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
	
	void Update () 
	{
		CheckHit ();

        if (!isPlayingCord)
        {
            audioSource.Stop();
        }
	}

	private void CheckHit()
	{
		RaycastHit hit;
		if (Physics.Raycast(rayObjectDir.position, rayObjectDir.forward, out hit, maxHitDistnace))
		{
			if (hit.collider.gameObject.tag.Equals("Gaze"))
			{
				if (lastObject != null && !hit.collider.gameObject.Equals (lastObject)) 
				{
					Deselect ();
				}

				if (!isSelected) 
				{
					Select (hit.collider.gameObject);
				}

                  } else {
					
					if (isSelected) //hit normal object without the "Gaze" tag
					{
						Deselect();
					}

                    else 
					{
						Deselect(); // nothing is selected
					}
				}
			}

	}
	
	private void Select(GameObject hitObject)   //when hit by the raycast change color to blue and play a cord
	{
        isSelected = true;

		changeMaterial = hitObject.GetComponent<ChangeMaterial>();
		changeMaterial.ChangeTo ("blue");

		lastObject = hitObject;

        isPlayingCord = true;
        if (isPlayingCord)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }

    private void Deselect() //when the lat object that was selected is NOT hit by the raycast change color back to red
	{
        isSelected = false;
		if (changeMaterial != null)
		{
			changeMaterial.ChangeTo ("red");
		}
        audioSource.Stop();
        isPlayingCord = false;
	}
}
