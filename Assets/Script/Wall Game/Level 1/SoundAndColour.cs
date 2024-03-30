using UnityEngine;

public class SoundAndColour : MonoBehaviour
{
    public AudioClip sound;
    private AudioSource playerAudio;
    public MeshRenderer meshRenderer;
    public GameObject activate;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            meshRenderer.material.color = Color.blue;
            playSound();
            activate.SetActive(true);
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
