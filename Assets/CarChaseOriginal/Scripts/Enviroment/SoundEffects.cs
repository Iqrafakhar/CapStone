using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public static AudioClip fireSound, playerSound, enemyDestroyingSound, HitingSound;
     static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        playerSound = Resources.Load<AudioClip>("PlayerMovement");
        enemyDestroyingSound = Resources.Load<AudioClip>("enemyDestroy");
        fireSound = Resources.Load<AudioClip>("shooting");
        HitingSound = Resources.Load<AudioClip>("Hiting");
        audioSrc = GetComponent<AudioSource>();

    }

    //function for player sound
    public static void playSound(string clip)
    {
        switch(clip)
        {
            case "PlayerMovement":
                audioSrc.PlayOneShot(playerSound);
                break;
            case "enemyDestroy":
                audioSrc.PlayOneShot(enemyDestroyingSound);
                break;
            case "shooting":
                audioSrc.PlayOneShot(fireSound);
                break;
            case "Hitting":
                audioSrc.PlayOneShot(HitingSound);
                break;
        }
    }
}

