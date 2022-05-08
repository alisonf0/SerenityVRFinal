using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSettings : MonoBehaviour
{
    // This variable stores the value of the music volume from the slider.
    public Slider musicVolume;
    // This variable stores the value of the meditation volume from the slider.
    public Slider medVolume;
    // This variable stores the value of the SFX volume from the slider.
    public Slider sfxVolume;



    // Start is called before the first frame update
    void Start()
    {
        // Initialising the volume variables.
        musicVolume.value = PlayerPrefs.GetFloat("MusicVolume");
        sfxVolume.value = PlayerPrefs.GetFloat("SfxVolume");
        medVolume.value = PlayerPrefs.GetFloat("MedVolume");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetVolumes()
    {
        //This sets the value of the music volume to be equal to the music slider's value.
        PlayerPrefs.SetFloat("MusicVolume", musicVolume.value);
        //Repeating for the SFX slider.
        PlayerPrefs.SetFloat("SfxVolume", sfxVolume.value);
        //Repeating for the meditation track slider.
        PlayerPrefs.SetFloat("MedVolume", medVolume.value);

    }
}
