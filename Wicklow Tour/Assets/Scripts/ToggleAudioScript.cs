using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAudioScript : MonoBehaviour
{
    // Start is called before the first frame update

    //public AudioClip MusicClip;

    public AudioSource MusicSource;
    bool isPlaying = false;

    public void toggleAudio()
    {
        if (!isPlaying)
        {
            isPlaying = true;

            MusicSource.Play();

        }
        else if (isPlaying)
        {
            isPlaying = false;
            MusicSource.Stop();
        }
    }

}
