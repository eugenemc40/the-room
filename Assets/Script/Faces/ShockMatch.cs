using UnityEngine;

public class ShockMatch : MonoBehaviour
{

    public AudioClip sound;
    private AudioSource playerAudio;
    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Shock"))
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
