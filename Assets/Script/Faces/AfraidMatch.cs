using UnityEngine;

public class AfraidMatch : MonoBehaviour
{
    public AudioClip sound;
    private AudioSource playerAudio;
    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Afraid"))
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
