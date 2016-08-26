using UnityEngine;
using System.Collections;

public class AudioTrigger : MonoBehaviour {

    public AudioSource source;
   // public AudioClip[] clip;

    public void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           Play();
        }
    }

    public void Play()
    {
        Debug.Log("Play Constellation Audio Clip");
        source.Play();
    }
}
