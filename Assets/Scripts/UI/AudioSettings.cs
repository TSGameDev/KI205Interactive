using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioSettings : MonoBehaviour
{
    [SerializeField] Slider masterAudio;
    [SerializeField] Slider musicAudio;
    [SerializeField] Slider soundsAudio;
    [SerializeField] Slider voiceAudio;

    [SerializeField] AudioMixer masterMix;

    private void Update()
    {
        masterMix.SetFloat("MasterVol", masterAudio.value);
        masterMix.SetFloat("MusicVol", musicAudio.value);
        masterMix.SetFloat("SoundVol", soundsAudio.value);
        masterMix.SetFloat("VoiceVol", voiceAudio.value);
    }
}
