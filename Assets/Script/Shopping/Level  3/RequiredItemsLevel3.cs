using UnityEngine;

public class RequiredItemsLevel3 : MonoBehaviour
{
    public GameObject setActive1;
    public GameObject setActive2;
    public GameObject setActive3;
    public GameObject setActive4;
    public AudioClip sound;
    private AudioSource playerAudio;
    int itemprice1;
    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bread"))
        {
            setActive1.SetActive(true);
            playSound();
        }
        if (other.gameObject.CompareTag("Steak"))
        {
            setActive2.SetActive(true);
            playSound();
        }
        if (other.gameObject.CompareTag("Cheese"))
        {
            setActive3.SetActive(true);
            playSound();
        }
        if (other.gameObject.CompareTag("Watermellon"))
        {
            setActive4.SetActive(true);
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
