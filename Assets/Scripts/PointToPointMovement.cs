using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PointToPointMovement : MonoBehaviour
{
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