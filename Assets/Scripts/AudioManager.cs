using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager am;
    public AudioSource SoundPlayer;
    private void Start()
    {
        am = this;
    }



    public void PlaySound(string name)
    {
        AudioClip safeBox = Resources.Load<AudioClip>("SafeBox");
        SoundPlayer.clip = safeBox;
        //SoundPlayer.PlayOneShot(safeBox);   
    }


}
