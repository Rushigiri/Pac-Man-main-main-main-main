using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiManage : MonoBehaviour
{
   // public static bool GameIsPause = false;
    public GameObject pauseCanvas;
    public GameObject LevelCompleteCanvas;
    public GameObject gameOverCanvas;
    public static uiManage instance;
    public int nextLevelNum;
    public int restartLevelNum;

    private void Awake()
    {
        
        instance = this;
    }
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
      // CoinHolderBehaviour.Instance.playerTotalScore = 0;

        SceneManager.LoadScene(restartLevelNum);
    }

    public void GotoHomePage()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void LevelCompletePage()
    {
        gameOverCanvas.SetActive(false);

        LevelCompleteCanvas.SetActive(true);
    }

    public void NextLevelPage()
    {

        LevelCompleteCanvas.SetActive(false);
        SceneManager.LoadScene(nextLevelNum);
    }

    
}
