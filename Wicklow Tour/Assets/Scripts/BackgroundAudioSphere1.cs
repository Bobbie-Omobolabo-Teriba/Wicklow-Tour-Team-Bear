using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudioSphere1 : MonoBehaviour
{
    //create audioclip for script to find audio file- this will hold sound effects so unity can play it
    public AudioClip MusicClip1;

    //reference to audiosource
    public AudioSource MusicSource1;

    //create audioclip for script to find audio file- this will hold sound effects so unity can play it
    public AudioClip MusicClipMain1;

    //reference to audiosource
    public AudioSource MusicSourceMain1;


    bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        //load music into audio source - set audio source to our audio file Musicclip
        MusicSource1.clip = MusicClip1;
        MusicSource1.Play();
        MusicSource1.loop = true;

        //load music into audio source - set audio source to our audio file Musicclip
        MusicSourceMain1.clip = MusicClipMain1;
        MusicSourceMain1.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if user presses the mouse down on a location - 0 for the primary button (often the left button)
        if (Input.GetMouseButtonDown(0))
        {
            //RayCast is an operation from the camera point sending out a "ray" find the surface it collides with
            RaycastHit hit;

            //A ray is an infinite line starting at origin and going in some direction.
            //this ray is set from the main camera to the position of the mouse
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //Physics.raycast() Casts a ray, from point origin, in direction direction, of length maxDistance, 
            //against all colliders in the Scene.
            //the starting point is the ray and direction is the raycast hit
            //"out" allows for the initial value to be assigned within the calling method
            if (Physics.Raycast(ray, out hit))
            {
                //if the name of the object being hit is arrow 1 then stop the music in the scene
                if (hit.transform.name == "arrow 1")
                    MusicSource1.Stop();

                //if the name of the object being hit is info_icon then play the music in the scene
                //and set isplaying to true
                if (hit.transform.name == "info_icon")
                {
                   
                    //audioSource.SetActive(hit.transform.name == "info_icon");

                    //if the audio is playing and the name of the object being hit is info_icon then play the music in the scene
                    //then stop the music & set isplaying to false
                    if (!isPlaying)
                    {
                        isPlaying = true;

                         MusicSourceMain1.Play();

                    }
                    else if (isPlaying)
                    {
                        isPlaying = false;
                        MusicSourceMain1.Stop();
                    }


                }

               
                    


               
            }


        }
    }
}
