using UnityEngine;
using UnityEngine.SceneManagement;

public class logo : MonoBehaviour
{
    public float delay = 2.0f;
    public string nextSceneName;
    private float timer = 0.0f;
    public void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            SceneManager.LoadScene(4);
        }
    }
}
