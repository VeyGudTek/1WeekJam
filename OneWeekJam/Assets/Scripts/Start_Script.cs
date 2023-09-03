using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void start_game()
    {
        SceneManager.LoadScene("Main");
    }

    public void quit_game()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
