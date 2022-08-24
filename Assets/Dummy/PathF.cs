using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathF : MonoBehaviour
{
   // [SerializeField] Transform PathPrefebs;
    [SerializeField] int MoveSpeed = 5;
    public List<Transform> WayPoints;

    int currentPosition;
    int followPosition;
    // float WaitTime;
    bool tranfered = false;
   // public float StartWaitTime;

    void Start()
    {
       // WaitTime = StartWaitTime;    //
        //WayPoints = GetWayPoints();
        currentPosition = Random.Range(0, WayPoints.Count);  //take min to max in list
        transform.position = WayPoints[currentPosition].position;
        followPosition = Random.Range(0, WayPoints.Count); //Start Position
        Debug.Log("CP1 :" + currentPosition);
        Debug.Log("wp" + WayPoints.Count);

    }

    private void Update()
    {
        FollowPath();
    }


    //List<Transform> GetWayPoints()  //List Of WayPoints In Path
    //{
    //    List<Transform> WayPoints = new List<Transform>();
    //    foreach (Transform child in PathPrefebs)
    //    {
    //        WayPoints.Add(child);
    //    }
    //    return WayPoints;
    //}

    void FollowPath()   //Follow Path
    {
        Debug.Log("tt");

        //current = target (position)
        Vector3 targetPosition = WayPoints[followPosition].position;   //target position way point index = 0
        float delta = MoveSpeed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, delta);
        float dist = Vector3.Distance(targetPosition, transform.position);
        Debug.Log(dist);
        if (dist <= 0.1f)
        {
            Debug.Log("ttt");

            if (tranfered)
            {
                Debug.Log("t");
                currentPosition = followPosition;
                followPosition = Random.Range(0, WayPoints.Count);
                tranfered = false;                    
               // WaitTime = StartWaitTime;
            }
            else
            {
                Debug.Log("f");


                tranfered = true;
               // WaitTime -= Time.deltaTime;
            }
        }

        if (transform.position == targetPosition)
        {
            Debug.Log("tttt");

            followPosition = Random.Range(0, WayPoints.Count);
            Debug.Log("Fp2 :" + followPosition);
        }


    }

}
