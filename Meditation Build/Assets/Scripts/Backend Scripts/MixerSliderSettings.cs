using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerSliderSettings : MonoBehaviour
{
    //Setting the mixer.
    [SerializeField] private AudioMixer projectMixer;

    public void SetMeditationMixerVolume(float sliderValue)
    {
        //Setting the volume for the meditation track.
        // The Mathf converts it from linear to logarithmic.
        // This makes it more accurate.
        projectMixer.SetFloat("MedMixerVolume", Mathf.Log10(sliderValue) * 20);
    }

        public void SetMusicMixerVolume(float sliderValue)
    {
        //Setting the volume for the music.
        // The Mathf converts it from linear to logarithmic.
        // This makes it more accurate.
        projectMixer.SetFloat("MusicMixerVolume", Mathf.Log10(sliderValue) * 20);
    }

        public void SetSFXMixerVolume(float sliderValue)
    {
        //Setting the volume for the ambient sounds in tthe meditation.
        // The Mathf converts it from linear to logarithmic.
        // This makes it more accurate.
        projectMixer.SetFloat("SFXMixerVolume", Mathf.Log10(sliderValue) * 20);
    }
}
