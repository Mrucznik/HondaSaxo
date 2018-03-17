using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour {

    public AudioMixer audioMixer;
    public AudioMixer musicAudioMixer;
       public void SetMasterVolume(float volume)
        {
            audioMixer.SetFloat("masterVolume", volume);
        }
        public void SetMusicVolume(float volume)
        {
            musicAudioMixer.SetFloat("musicVolume", volume);
        }
}
