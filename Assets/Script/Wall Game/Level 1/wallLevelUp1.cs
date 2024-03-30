using UnityEngine;
using UnityEngine.SceneManagement;

public class wallLevelUp1 : MonoBehaviour
{
    public GameObject get1;
    public GameObject get2;
    public int level;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (get1.activeSelf && get2.activeSelf)
        {
            levelChange(level);
        }
    }
    public void levelChange(int level)
    {
        SceneManager.LoadScene(level);
    }
}
