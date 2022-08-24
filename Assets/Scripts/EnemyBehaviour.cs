using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{

    //public List<Transform> transforms;
    //int i = 0;
    //public float speed;

    //private void Update()
    //{
    //    moving();
    //}

    //void moving()
    //{
    //    transform.position = Vector2.Lerp(transform.position, transforms[i].position, speed * Time.deltaTime);
    //    if (transform.position == transforms[i].position)
    //    {
    //        i++;
    //        if (transforms.Count == i)
    //        {
    //            i = 0;
    //        }
    //    }
    //}
    //[SerializeField] Transform PathPrefebs;
    //[SerializeField] int MoveSpeed = 5;
    //List<Transform> Points;
    //int PointIndex = 0;
    //void Start()
    //{
    //    Points = GetPoints();
    //    transform.position = Points[PointIndex].position; //Start Position
    //}

    //private void Update()
    //{
    //    FollowPath();
    //}


    //List<Transform> GetPoints()  //List Of WayPoints In Path
    //{
    //    List<Transform> WayPoints = new List<Transform>();
    //    foreach (Transform child in PathPrefebs)
    //    {
    //        WayPoints.Add(child);
    //    }
    //    return WayPoints;
    //}

    //void FollowPath()   //Follow Path
    //{
    //    Vector3 targetPosition = Points[PointIndex].position;
    //    transform.position = Vector2.MoveTowards(transform.position, targetPosition, MoveSpeed * Time.deltaTime);

    //    if (transform.position == targetPosition)
    //    {
    //        PointIndex++;
    //    }
    //    int list_lenght = Points.Count;

    //    if (list_lenght == PointIndex)
    //    {
    //        PointIndex = 0;
    //    }
    //}





    //public void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        Debug.Log("destroy");
    //        Destroy(gameObject);
    //    }

    //}
    //NavMeshAgent navAgent;

    //private void Start()
    //{
    //    navAgent = GetComponent<NavMeshAgent>();
    //}
    //private void Update()
    //{
    //    navAgent.SetDestination(PlayerBehaviour.Instance.transform.position);

    //}



    //public Transform playerPosition;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    NavMeshAgent agent = GetComponent<NavMeshAgent>();
    //    agent.destination = playerPosition.position;
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}

