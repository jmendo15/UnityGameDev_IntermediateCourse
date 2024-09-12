using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false; // Tracks whether the game is currently paused
    public GameObject pauseMenuUI;           // Reference to the Pause Menu UI
    public string sceneToLoad;

    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ResumeGame(); // Resume the game if it is already paused
            }
            else
            {
                PauseGame(); // Pause the game if it is not paused
            }
        }
    }

    // Method to resume the game
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);        // Hide the pause menu UI
        Time.timeScale = 1f;                 // Set time scale back to normal
        GameIsPaused = false;                // Mark the game as unpaused
    }

    // Method to pause the game
    void PauseGame()
    {
        pauseMenuUI.SetActive(true);         // Show the pause menu UI
        Time.timeScale = 0f;                 // Freeze the game by setting time scale to 0
        GameIsPaused = true;                 // Mark the game as paused
    }

    // Method to restart the current scene
    public void RestartGame()
    {
        Time.timeScale = 1f;                 // Reset time scale to normal in case the game was paused
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
    }

    // Method to load the main menu scene
    public void LoadMainMenu()
    {
        Time.timeScale = 1f;                 // Reset time scale to normal
        SceneManager.LoadScene(sceneToLoad);  // Load the main menu scene (replace "MainMenu" with the actual scene name)
    }
}