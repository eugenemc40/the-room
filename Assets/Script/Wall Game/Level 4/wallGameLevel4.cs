using UnityEngine;
using UnityEngine.SceneManagement;

public class wallGameLevel4 : MonoBehaviour
{
    public GameObject get1;
    public GameObject get2;
    public GameObject get3;
    public GameObject get4;
    public GameObject get5;

    public int level;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (get1.activeSelf && get2.activeSelf && get3.activeSelf && get4.activeSelf && get5.activeSelf)
        {
            levelChange(level);
        }
    }

    public void levelChange(int level)
    {
        SceneManager.LoadScene(level);
    }
}
