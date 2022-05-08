using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathingLoader : MonoBehaviour
{
    //Calling the breathing exercise game objects.
    public GameObject circleBreathing;
    public GameObject squareBreathing;


    // Start is called before the first frame update
    void Start()
    {
        int breatheNum = PlayerPrefs.GetInt("breatheNum");
        //Printing a message to the console.
        Debug.Log("Loading breathing exercise selection.");

    //If the user selects the circle breathing exercise, activate the circle breathing and deactivate the square breathing.
        if (breatheNum == 1){
            circleBreathing.SetActive(true);
            squareBreathing.SetActive(false);
        }

        //If the user selects the square breathing exercise, activate the square breathing and deactivate the circle breathing.
        if (breatheNum == 2){
            circleBreathing.SetActive(false);
            squareBreathing.SetActive(true);
        }

        //If the user selects no breathing exercise, deactivate the square breathing and the circle breathing.
        else if (breatheNum == 0){
            circleBreathing.SetActive(false);
            squareBreathing.SetActive(false);
        }
    }

}
