using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiManage : MonoBehaviour
{
   // public static bool GameIsPause = false;
    public GameObject pauseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GamePause()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale = 0f;

    }

    public void ResumeLevel()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1f;
    }
    

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
       CoinHolderBehaviour.Instance.playerTotalScore = 0;

        SceneManager.LoadScene(1);
    }

    public void GotoHomePage()
    {
        SceneManager.LoadScene(0);
    }
}
