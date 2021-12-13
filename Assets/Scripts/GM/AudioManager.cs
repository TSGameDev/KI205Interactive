using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioManager instance = null;

    [SerializeField] float randomPitchMax = 1.5f;
    [SerializeField] float randomVolumeMax = 1f;
    [SerializeField] float randomPitchMin = 0.5f;
    [SerializeField] float randomVolumeMin = 0.5f;

    private void Awake()
    {
        if(instance == null)
            instance = this;
        else if(instance != this)
            Destroy(this);
    }

    public void PlayClipWithVariation(AudioSource source, AudioClip clip)
    {
        float randomVolume = Random.Range(randomVolumeMin, randomVolumeMax);
        float randomPitch = Random.Range(randomPitchMin, randomPitchMax);

        source.clip = clip;
        source.pitch = randomPitch;
        source.volume = randomVolume;
        source.Play();
    }
}
