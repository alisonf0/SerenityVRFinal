using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is a script that gets the volume settings for the ambient sound effects and plays them in the scene.

public class AmbientSettings : MonoBehaviour
{
    //Initialising the Audio Source.
    public AudioSource AmbientPlayer;

    void Start()
    {
        //Setting the track to repeat.
         AmbientPlayer.loop = true;
         AmbientPlayer.volume = PlayerPrefs.GetFloat("SfxVolume");
         AmbientPlayer.Play();
         //Printing a message to the console.
         Debug.Log("Playing ambient audio at volume level " + AmbientPlayer.volume);


        
    }

}
