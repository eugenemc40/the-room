using UnityEngine;

public class wallGameLevel5Win : MonoBehaviour
{
    public GameObject get1;
    public GameObject get2;
    public GameObject get3;
    public GameObject get4;
    public GameObject get5;
    public GameObject get6;
    public GameObject get7;
    public GameObject get8;
    public GameObject get9;
    public GameObject get10;
    public GameObject setAcive;
    public GameObject deactivate;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (get1.activeSelf && get2.activeSelf && get3.activeSelf && get4.activeSelf && get5.activeSelf && get6.activeSelf && get7.activeSelf
            && get8.activeSelf && get9.activeSelf && get10.activeSelf)
        {
            setAcive.SetActive(true);
            deactivate.SetActive(false);
        }
    }
}
