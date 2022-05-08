using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadVRScene(string sceneName)
    {
        //Calling the SceneManager to load the trial scene.
        SceneManager.LoadScene(sceneName);
    }

    // This is the function to quit the application.
     public void quitApp() {
    Debug.Log("Quitting application.");
     Application.Quit();
 }

    //This function reloads the current scene.
     public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
