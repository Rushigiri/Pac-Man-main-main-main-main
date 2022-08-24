using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PointToPointMovement : MonoBehaviour
{

    //[SerializeField]
    //Transform playerTransform;

    //public List<Transform> transformList;
    //int counter;
    //int moveSpeed;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    counter = 0;
    //    moveSpeed = 50;
    //}
    //Transform currentTransform;
    //// Update is called once per frame
    //void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.X))
    //    {
    //        currentTransform = transformList[counter];

    //        counter++;

    //        if (counter >= transformList.Count)
    //        {
    //            counter = 0;
    //        }

    //    }

    //    Vector2 directionTogo = transformList[counter].position - transform.position;
    //    playerTransform.Translate(directionTogo.normalized * Time.deltaTime * moveSpeed);
    //    playerTransform.position = Vector3.MoveTowards(transform.position, currentTransform.position);
    //    //Changeposition();
    //}


    //async void Changeposition()
    //{
    //    await Task.Delay(3000);


    //}
    public List<Transform> cubes;
    int i = 0;

    void Start()
    {


    }

    // Move to the target end position.
    void Update()
    {
        
            transform.position = Vector3.MoveTowards(transform.position, cubes[i].position, 2f * Time.deltaTime   );
            if (transform.position == cubes[i].position)
            {
                i++;
                if (i >= cubes.Count)
                {
                    i = 0;
                }
            }
        }

    
}