using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudioSphere3 : MonoBehaviour
{
    //create audioclip for script to find audio file- this will hold sound effects so unity can play it
    public AudioClip MusicClip3;

    //reference to audiosource
    public AudioSource MusicSource3;

    // Start is called before the first frame update
    void Start()
    {
        //load music into audio source - set audio source to our audio file Musicclip
        MusicSource3.clip = MusicClip3;
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
                //if the name of the object being hit is arrow 2 then stop the music in the scene
                if (hit.transform.name == "arrow 2")
                {
                    MusicSource3.Play();
                    MusicSource3.loop = true;
                }
                else
                {
                    MusicSource3.Stop();
                }
            }


        }
    }
}
