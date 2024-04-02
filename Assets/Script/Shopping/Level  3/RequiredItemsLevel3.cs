using UnityEngine;

public class RequiredItemsLevel3 : MonoBehaviour
{
    public GameObject setActive1;
    public GameObject setActive2;
    public GameObject setActive3;
    public GameObject setActive4;

    int itemprice1;
    private void Start()
    {



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bread"))
        {
            setActive1.SetActive(true);

        }
        if (other.gameObject.CompareTag("Steak"))
        {
            setActive2.SetActive(true);

        }
        if (other.gameObject.CompareTag("Cheese"))
        {
            setActive3.SetActive(true);

        }
        if (other.gameObject.CompareTag("Watermelon"))
        {
            setActive4.SetActive(true);

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
