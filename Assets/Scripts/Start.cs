using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene("Level_01");
    }

   
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game closed!");
    }
}
