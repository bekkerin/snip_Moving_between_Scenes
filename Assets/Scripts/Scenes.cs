using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("game");
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("exit");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("intro");
    }

    public void ExitGame()
    {
        // exit the game for real play
        Application.Quit();
        //does not work in Unity since it would  lose all settings. so:
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
