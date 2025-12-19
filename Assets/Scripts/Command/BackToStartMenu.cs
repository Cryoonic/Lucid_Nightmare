using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStartMenu : MonoBehaviour
{
    public void BackToMenu()
    {
    
        SceneManager.LoadScene("StartMenu");
    }
}
