using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is a script used by the settings buttons in the home scene.
// It contains code that is used to assign the selected meditation parameters to PlayerPrefs.ini.
// This is done because PlayerPrefs.ini retains the information through sessions and scenes.

public class MeditationSettings : MonoBehaviour
{
    public void SetMusic (int musicNum)
    {
        //This sends a message to the console to log the music number selected.
        Debug.Log("Setting the music track to track number " + musicNum);
        PlayerPrefs.SetInt("musicNum", musicNum);
    }

        public void ClearMusic ()
    {
        //This sends a message to the console to log the music number selected.
        Debug.Log("Clearing Music Selection.");
        PlayerPrefs.SetInt("musicNum", 0);
    }

        public void SetMedTrack (int medTrackNum)
    {
        //This sends a message to the console to log the meditation track number selected.
        Debug.Log("Setting the meditation track to track number " + medTrackNum);
        PlayerPrefs.SetInt("medTrackNum", medTrackNum);
    }

        public void ClearMedTrack ()
    {
        //This sends a message to the console to log the meditation track number selected.
        Debug.Log("Clearing meditation track selection.");
        PlayerPrefs.SetInt("medTrackNum", 0);
    }


 //Code related to breathing exercises.
    public void SetBreathe (int breatheNum)
    {
        //This sends a message to the console to log the selected breathing exercise.
        Debug.Log("Setting the breatthing exercise to " + breatheNum);
        PlayerPrefs.SetInt("breatheNum", breatheNum);
    }

        public void clearBreathe (int breatheNum)
    {
        //This sends a message to the console to log that the breathing exercise has been cleared.
        Debug.Log("Clearing the breathing exercise selection.");
        PlayerPrefs.SetInt("breatheNum", 0);
    }
}
