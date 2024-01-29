using UnityEngine;

public class HappyMatch : MonoBehaviour
{

    public AudioClip sound;
    private AudioSource playerAudio;
    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Happy"))
        {
            playSound();
        }

    }




    private void playSound()
    {
        if (sound != null && playerAudio != null)
        {
            playerAudio.PlayOneShot(sound, 1.0f);
        }
    }
}

