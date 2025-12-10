using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level_01");
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level_01 1");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level_01 2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
