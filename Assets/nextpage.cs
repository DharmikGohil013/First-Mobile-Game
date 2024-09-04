using UnityEngine;
using UnityEngine.SceneManagement;

public class nextpage : MonoBehaviour
{
    // Time in seconds before the scene changes
    public float delay = 2.0f;

    // Name of the next scene to load
    public string nextSceneName;

    // Timer to keep track of time passed
    private float timer = 0.0f;

    public void Update()
    {
        // Increment the timer by the time passed since the last frame
        timer += Time.deltaTime;

        // Check if the delay has passed
        if (timer >= 1)
        {
            // Load the next scene
            SceneManager.LoadScene(1);
        }
    }
}
