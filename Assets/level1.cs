using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level1 : MonoBehaviour
{
    // Start is called before the first frame update
    public int x = 0;
    public Text numberText;
    void Start()
    {
        UpdateNumberText();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void plus()
    {
        x = x + 1;
        UpdateNumberText();
    }
    public void minus()
    {
        x = x - 1;
        UpdateNumberText();
    }
    private void UpdateNumberText()
    {
        numberText.text = x.ToString();
    }
    public void back()
    {
        SceneManager.LoadScene(6);
    }
}
