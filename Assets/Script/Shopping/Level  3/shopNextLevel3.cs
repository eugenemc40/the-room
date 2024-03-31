using UnityEngine;

public class shopNextLevel3 : MonoBehaviour
{

    public GameObject update1;
    public GameObject update2;
    public GameObject update3;
    public GameObject update4;
    public GameObject update5;
    public GameObject setUpdate1;
    public AudioClip sound;
    private AudioSource playerAudio;
    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();


    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Trolly") && update1.activeSelf && update2.activeSelf && update3.activeSelf && update4.activeSelf && update5.activeSelf)
        {
            setUpdate1.SetActive(true);
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
