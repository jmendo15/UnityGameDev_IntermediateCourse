using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management functions

public class LevelManagement : MonoBehaviour
{
    // Name of the next level/scene to load
    public string nextLevelName;

    // This function is called when another collider enters a trigger collider attached to the same GameObject
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object colliding with the trigger is tagged as "Player" (the ball)
        if (other.CompareTag("Key"))
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
