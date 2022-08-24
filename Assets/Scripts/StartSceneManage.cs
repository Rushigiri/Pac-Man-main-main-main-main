using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneManage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 3.1f)
        {
            transform.position = new Vector3(-3.8f,transform.position.y,transform.position.z);
        }
        //if (transform.position.x <= -9)
        //{
        //    transform.position = new Vector3(9, transform.position.y, transform.position.z);
        //}

        transform.Translate(Vector2.right * 1 * Time.deltaTime);

        //transform.position += new Vector3(transform.position.x + 0.5f * Time.deltaTime, transform.position.y, transform.position.z);
    }
}
