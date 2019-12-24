using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudioSphere2 : MonoBehaviour
{
    //create audioclip for script to find audio file- this will hold sound effects so unity can play it
    public AudioClip MusicClip2;

    //reference to audiosource
    public AudioSource MusicSource2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Awake is called after all objects are initialized so you can safely speak to other objects or query them 
    void Awake()
    {
        //load music into audio source - set audio source to our audio file Musicclip

        //MusicSource2.loop = true;
        MusicSource2.clip = MusicClip2;
        MusicSource2.Play();
        MusicSource2.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
