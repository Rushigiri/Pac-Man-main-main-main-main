using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject Player;
     int totalScore = 10;

     void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("ok");

        if (collision.tag == "Player")
        {
            //PlayerBehaviour.Instance. -- ;
            //Debug.Log(PlayerBehaviour.Instance.coins.Count);
            ScoreManagement.instance.simpleCoinScore(totalScore);
            Destroy(gameObject);
        }
            

    }

}
