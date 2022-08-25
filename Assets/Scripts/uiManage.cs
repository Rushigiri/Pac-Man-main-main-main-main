using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiManage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void RestartLevel()
    {
       CoinHolderBehaviour.Instance.playerTotalScore = 0;

        SceneManager.LoadScene(1);
    }

    public void GotoHomePage()
    {
        SceneManager.LoadScene(0);
    }
}
