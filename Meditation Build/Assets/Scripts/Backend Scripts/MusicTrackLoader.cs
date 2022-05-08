using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is a script that is called in order to play the music.
// It loads the different songs and assigns them to variables.
// It then plays the selected music by calling the user's choice from PlayerPrefs.ini.

public class MusicTrackLoader : MonoBehaviour
{

    //Initialising the MusicNum variable.
    //This variable loads the number assigned to the music that the player has selected.
    public int musicNum;

    //Initialising the Audio Source.
    public AudioSource MusicPlayer;

    //Loading the music.
     public AudioClip Song1;
     public AudioClip Song2;
     public AudioClip Song3;
      public AudioClip Song4;
     public AudioClip Song5;

    void Start()
    {
        //Getting the number of the song from the PlayerPrefs and assigning it to musicNum.
        int musicNum = PlayerPrefs.GetInt("musicNum");

        if (musicNum == 1){
            MusicPlayer.clip = Song1;
        }

        else if (musicNum == 2){
            MusicPlayer.clip = Song2;
        }

        else if (musicNum == 3){
            MusicPlayer.clip = Song3;
        }

        else if (musicNum == 4){
            MusicPlayer.clip = Song4;
        }

        else if (musicNum == 5){
            MusicPlayer.clip = Song5;
        }

         MusicPlayer.loop = true;
         MusicPlayer.volume = PlayerPrefs.GetFloat("MusicVolume");
         MusicPlayer.Play();
        //Printing a message to the console.
        Debug.Log("Playing music track " + musicNum + " at volume level " + MusicPlayer.volume);
        
    }

}
