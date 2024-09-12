using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string sceneToLoad;

    // Method to be called when the Play button is pressed
    public void PlayGame()
    {
        // Load the next scene in the build order (or specify a scene by name)
        SceneManager.LoadScene(sceneToLoad); // Replace "GameScene" with the actual scene name
    }

    // Method to be called when the Exit button is pressed
    public void ExitGame()
    {
        // Quit the application
        Debug.Log("Game is exiting...");
        Application.Quit();
    }
}