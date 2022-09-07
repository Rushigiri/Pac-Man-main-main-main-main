using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // for level selection screen

    public void Level1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }
    public void Level2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(3);
    }
    public void Level3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(4);
    }
    public void Level4()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(5);
    }
    public void Level5()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(6);
    }
    public void GotoHomePage()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
}
