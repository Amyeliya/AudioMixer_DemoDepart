using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GestionnaireAudio : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audioMixer;

    [SerializeField]
    private Slider glissiereVolumeMusique;

    [SerializeField]
    private Slider glissiereVolumeFX;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        //audioMixer.GetFloat("MusiqueVolume");

        //audioMixer.SetFloat("MusiqueVolume", -20f);
    }

    public void AjusteVolumeMusique(float volume){
        audioMixer.SetFloat("MusiqueVolume", ConvertToLogarithmique(volume));
    }

    public void AjusteVolumeFX(float volume){
        audioMixer.SetFloat("FXVolume", ConvertToLogarithmique(volume));
        audioSource.Play();
    }

    private float ConvertToLogarithmique(float volume){
        return Mathf.Log10(volume) * 20;
    }
    //void s'il n'y a pas de return, mais si fait return pas de void.
}
