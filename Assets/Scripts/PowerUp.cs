using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    int totalScore = 20;
    int endTime = 5;
    int startTime = 0;
    void Update()
    {
        //Debug.Log(PlayerBehaviour.Instance.startTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
          //if (collision.tag == "Player")

          //{
                
          //      Destroy(gameObject);
          //}


        

        if (collision.gameObject.CompareTag("Player") && !PlayerBehaviour.Instance.isPowerOn)
        {
            PlayerBehaviour.Instance.playerSprite.color = Color.red;
            ScoreManagement.instance.simpleCoinScore(totalScore);
            PlayerBehaviour.Instance.isPowerOn = true;
            //Debug.Log(PlayerBehaviour.Instance.isPowerOn);
            PlayerBehaviour.Instance.speed = 2.4f;
            PlayerBehaviour.Instance.startTime = startTime;
            PlayerBehaviour.Instance.endTime = endTime;
            gameObject.SetActive(false);
           
        }
        
    }


}
