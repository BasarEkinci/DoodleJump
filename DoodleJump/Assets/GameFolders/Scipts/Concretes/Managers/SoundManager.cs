using DoodleJump.Abstarcts;
using UnityEngine;

public class SoundManager : SingeltonThisObjects<SoundManager>
{

     private AudioSource[] audioSource;
    private void Awake()
    {
        SingeltonThisObject(this);
        audioSource = GetComponentsInChildren<AudioSource>();
    }

    public void PlaySound(int index)
    {
        if(!audioSource[index].isPlaying)
            audioSource[index].Play();
    }

    public void StopSound(int index)
    {
        if(audioSource[index].isPlaying)
            audioSource[index].Stop();
    }
}
