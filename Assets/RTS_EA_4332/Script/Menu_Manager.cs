using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {}
    public void StartGame()
    {
        // SceneManager.LoadScene("RTST_RoadScene", LoadSceneMode.Additive);
        SceneManager.LoadScene("RTST_RoadScene");
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void Quit_Game()
    {
        Application.Quit();
    }
}
