using UnityEngine;

public class LevelUp : MonoBehaviour
{
    public GameObject update1;
    public GameObject update2;
    public GameObject update3;
    public GameObject update4;
    public GameObject update5;
    public GameObject update6;
    public GameObject update7;
    public GameObject update8;
    public GameObject update9;
    public GameObject update10;
    public GameObject update11;
    public GameObject toActivate;
    public GameObject toDeactivate;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        toUpdate();
    }



    public void toUpdate()
    {
        if (update1.activeSelf && update2.activeSelf && update3.activeSelf && update4.activeSelf && update5.activeSelf && update6.activeSelf &&
            update7.activeSelf && update8.activeSelf && update9.activeSelf && update10.activeSelf && update11.activeSelf)
        {
            toActivate.SetActive(true);
            toDeactivate.SetActive(false);

        }
    }


}
