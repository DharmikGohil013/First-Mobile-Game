using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class signuppage : MonoBehaviour
{
    public string url = "https://www.google.co.in/";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void signinpageview()
    {
        SceneManager.LoadScene(2);
    }
    public void HOMEVIEW()
    {
        SceneManager.LoadScene(1);
    }
    public void GOOGLE()
    {
        Application.OpenURL(url);
    }
    public void fasbook()
    {
        Application.OpenURL(url);
    }
    public void phone()
    {
        Application.OpenURL(url);
    }
}
