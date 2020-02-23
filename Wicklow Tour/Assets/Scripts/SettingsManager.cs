using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SettingsManager : MonoBehaviour
{
    public AudioSource[] backgroundAudioSources;


    public Slider volume;   

    public void ChangeVolume()
    {
      
            foreach (AudioSource audioS in backgroundAudioSources)
            {
                audioS.volume = volume.value;

            }
      
    }

}
