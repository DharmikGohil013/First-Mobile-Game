using UnityEngine;
using UnityEngine.UI;

public class LevelMenuController : MonoBehaviour
{
    public GameObject buttonPrefab; // Assign your button prefab in the inspector
    public Transform contentPanel; // Assign the Content GameObject in the inspector

    void Start()
    {
        PopulateMenu();
    }

    void PopulateMenu()
    {
        int levelCount = 10; // Set how many levels you have
        for (int i = 0; i < levelCount; i++)
        {
            GameObject button = Instantiate(buttonPrefab); // Create a new button   
            button.transform.SetParent(contentPanel, false); // Attach to content panel
            button.GetComponentInChildren<Text>().text = "Level " + (i + 1); // Set button label

            int levelIndex = i + 1; // Store the level number for each button
            button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(levelIndex)); // Assign click event
        }
    }

    void OnButtonClick(int levelIndex)
    {
        Debug.Log("Loading Level " + levelIndex);
        // You can replace this with code to load the actual level
    }
}
