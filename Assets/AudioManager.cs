
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("---------- Audio Source ---------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------- Audio Source ---------")]
    public AudioClip backround;
    public AudioClip Death;
    public AudioClip Monster;
    public AudioClip Walk;
    public AudioClip Sprint;
    public AudioClip Click;
    public AudioClip Skogen;

    private void Start()
    {
        musicSource.clip = backround;
            musicSource.Play();
    }

}
