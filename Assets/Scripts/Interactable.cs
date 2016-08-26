using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour
{
    private Color starColor;                //ref to start color
    public bool targetted = false;
    private Material material;

    private AudioTrigger audioToPlay;

	// Use this for initialization
	void Start ()
    {
        material = GetComponent<Renderer>().material;
        starColor = material.color;
        audioToPlay = GetComponent<AudioTrigger>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (targetted)                      //check if this object has been targeted
        {
            Target();
            targetted = false;    
        }
        else
        {
            Untargeted();
        }
	}

    public void Target()
    {
        material.color = Color.green;
        audioToPlay.Play();
    }

    public void Untargeted()
    {
        material.color = starColor;
    }
}
