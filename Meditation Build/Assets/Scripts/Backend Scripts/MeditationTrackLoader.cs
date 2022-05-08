using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is a script that is called in order to play the meditation track audio.
// It loads the meditation tracks and assigns them to variables.
// It then plays the selected meditation track by calling the user's choice from PlayerPrefs.ini.

public class MeditationTrackLoader : MonoBehaviour
{

    //Initialising the MedTrackNum variable.
    //This variable loads the number assigned to the meditation track that the player has selected.
    public int medTrackNum;

    //Initialising the Audio Source.
    public AudioSource MeditationTrackPlayer;

    //Loading the meditation tracks.
     public AudioClip Track1;
     public AudioClip Track2;
     public AudioClip Track3;

    void Start()
    {
        //Getting the number of the meditation track from the PlayerPrefs and assigning it to medTrackNum.
        int medTrackNum = PlayerPrefs.GetInt("medTrackNum");

        if (medTrackNum == 1){
            MeditationTrackPlayer.clip = Track1;
        }

        else if (medTrackNum == 2){
            MeditationTrackPlayer.clip = Track2;
        }

        else if (medTrackNum == 3){
            MeditationTrackPlayer.clip = Track3;
        }

         MeditationTrackPlayer.loop = false;
         MeditationTrackPlayer.volume = PlayerPrefs.GetFloat("MedVolume");
         MeditationTrackPlayer.Play();
         //Printing a message to the console.
         Debug.Log("Playing meditation track " + medTrackNum +  "at volume level " + MeditationTrackPlayer.volume);


        
    }

}
