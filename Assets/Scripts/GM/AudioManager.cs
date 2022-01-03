using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioManager instance = null;

    #region Serialized Variables

    [SerializeField] float randomPitchMax = 1.5f;
    [SerializeField] float randomVolumeMax = 1f;
    [SerializeField] float randomPitchMin = 0.5f;
    [SerializeField] float randomVolumeMin = 0.5f;

    #endregion

    private void Awake()
    {
        //singlton
        if(instance == null)
            instance = this;
        else if(instance != this)
            Destroy(this);
    }

    /// <summary>
    /// Plays the passed in audio clip through the passed in audio source with a pitch and volume variation
    /// </summary>
    /// <param name="source">The desired source to play the sound through</param>
    /// <param name="clip">The clip to play</param>
    public void PlayClipWithVariation(AudioSource source, AudioClip clip)
    {
        float randomVolume = Random.Range(randomVolumeMin, randomVolumeMax);
        float randomPitch = Random.Range(randomPitchMin, randomPitchMax);

        source.clip = clip;
        source.pitch = randomPitch;
        source.volume = randomVolume;
        source.Play();
    }

    /// <summary>
    /// Plays a random clips from the passed in array of clips from the passed in audio source with pitch and volume variation
    /// </summary>
    /// <param name="source">The desired source to play the sound through</param>
    /// <param name="clips">An Array of audio clips to pick from</param>
    public void PlayWithClipVariation(AudioSource source, AudioClip[] clips)
    {
        int clipsNum = Random.Range(0, clips.Length);
        PlayClipWithVariation(source, clips[clipsNum]);
    }
}
