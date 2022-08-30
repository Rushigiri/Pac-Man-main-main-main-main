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
        Debug.Log("0");

        if (collision.gameObject.CompareTag("Player") && !PlayerBehaviour.Instance.isPowerOn)
        {
            Debug.Log("1");
            PlayerBehaviour.Instance.playerSprite.color = Color.red;
            Debug.Log("2");

            ScoreManagement.instance.simpleCoinScore(totalScore);
            Debug.Log("3");

            PlayerBehaviour.Instance.isPowerOn = true;
            Debug.Log("4");
            //Debug.Log(PlayerBehaviour.Instance.isPowerOn);

            PlayerBehaviour.Instance.speed = 2.4f;
            Debug.Log("5");

            PlayerBehaviour.Instance.startTime = startTime;
            Debug.Log("6");

            PlayerBehaviour.Instance.endTime = endTime;
            Debug.Log("7");

            //gameObject.SetActive(false);
            Destroy(gameObject);
           
        }
        
    }


}
