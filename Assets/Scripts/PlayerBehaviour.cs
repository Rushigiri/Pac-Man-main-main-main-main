using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{
    public SpriteRenderer playerSprite;
    public Rigidbody2D playerRigidBody;
    public float speed;
    public bool isPowerOn = false;
   public float startTime = 0f;
   public float endTime = 8f;
    public GameObject destoryParticle;
    public GameObject powerUpParticle;
    public GameObject powerUpSpawnPosition;
    //public ParticleSystem powerParticle;
    //public ParticleSystem particle;
    public float particleDestroyTime = 1f;
    //public float coinCount;
    public GameObject coinParent;
    public Transform spawnPoint;
    public GameObject[] enemy;
    public List<GameObject> coins;
    public int i;
    public GameObject GameOverCanvas;
    Vector2 moveDir;
    bool newSceneLoaded;
    public LayerMask levelcolide;

    public static PlayerBehaviour Instance;

    private void Awake()
    {
       
            Instance = this;
        

    }

    // Start is called before the first frame update
    void Start()
    {
        speed = 2f;
        playerRigidBody = GetComponent<Rigidbody2D>();
        //coinCount = coins.Count;
        //coinCount = CoinHolderBehaviour.Instance.coinsforEachLevel[CoinHolderBehaviour.Instance.levelCounter];
        newSceneLoaded = false;
        
    }

    // Update is called once per frame
    void Update()
    {



        if (coinParent.transform.childCount == 0)
        {
            //SceneManager.LoadScene(0);
            Debug.Log("ok");
           
           uiManage.instance.LevelCompletePage();
        }

        // spwan player one side to other side
        if (transform.position.x > 6)
        {
            transform.position = new Vector3(-7.3f, transform.position.y, transform.position.z);
        }
       else if (transform.position.x < -7.4 )
        {
            transform.position = new Vector3(6, transform.position.y, transform.position.z);
        }
        if (isPowerOn)
        {
            //powerParticle.Play();
            //Destroy(powerParticle, 5f);
            GameObject power = Instantiate(powerUpParticle, powerUpSpawnPosition.transform.position, Quaternion.identity);
            Destroy(power, 0.1f);
            startTime += Time.deltaTime;
        }

        if (startTime >= endTime)
        {
            playerSprite.color = Color.yellow;
            speed = 2f;
            startTime = 0f;
            endTime = 5f;
            isPowerOn = false;
        }

        }

    private void FixedUpdate()
    {
        Move();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "Enemy") && isPowerOn)
        {          
            ScoreManagement.instance.simpleCoinScore(200);
            Destroy(collision.gameObject);
            int enemyNum = Random.Range(0, enemy.Length);
            Instantiate(enemy[enemyNum], spawnPoint.position, Quaternion.identity);
        }
        else if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            GameObject blast = Instantiate(destoryParticle, transform.position, Quaternion.identity);
            Destroy(blast, 1f);
            // StartCoroutine(uiManage.instance.waitGameOverScreen(1));
            uiManage.instance.StartCoroutine(uiManage.instance.waitGameOverScreen(1));
        }
    }


    //player MoveMent
    public void Move()
    {
        playerRigidBody.MovePosition(playerRigidBody.position + (moveDir * speed * Time.deltaTime));
    }

    public void MoveUp()
    {
        if(!Physics2D.Linecast(transform.position,(Vector2)transform.position + new Vector2(0,1),levelcolide))
        {
            Debug.DrawLine(transform.position, (Vector2)transform.position + new Vector2(0, 1));
            moveDir = Vector2.up;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
            transform.localScale = new Vector3(-1, 1, 1);
        }        
    }

    public void MoveDown()
    {
        if (!Physics2D.Linecast(transform.position, (Vector2)transform.position + new Vector2(0, -1), levelcolide))
        {
            Debug.DrawLine(transform.position, (Vector2)transform.position + new Vector2(0, -1));

            moveDir = Vector2.down;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, -90));
            transform.localScale = new Vector3(-1, 1, 1);
        }   
    }

    public void MoveRight()
    {
        if (!Physics2D.Linecast(transform.position, (Vector2)transform.position + new Vector2(1, 0), levelcolide))
        {
            Debug.DrawLine(transform.position, (Vector2)transform.position + new Vector2(1, 0));

            moveDir = Vector2.right;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        transform.localScale = new Vector3(-1,1,1);
        }
    }

    public void MoveLeft()
    {
        if (!Physics2D.Linecast(transform.position, (Vector2)transform.position + new Vector2(-1, 0), levelcolide))
        {
            Debug.DrawLine(transform.position, (Vector2)transform.position + new Vector2(-1, 0));

            moveDir = Vector2.left;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        transform.localScale = new Vector3(1,1,1);

        }   
    }

    //public void DestroyAnimation(ParticleSystem destroypart)
    //{
    //    destroypart = GetComponent<ParticleSystem>();
    //    destroypart.Play();
    //    //destroypart = destroypart.duration;
    //    //Destroy(gameObject, destroypart.main.duration);
    //    destroypart.Stop();
    //}

}





//private void OnDestroy()
//{
//    CoinHolderBehaviour.Instance.levelCounter++;
//    CoinHolderBehaviour.Instance.playerTotalScore += ScoreManagement.instance.GetTotalScore();
//}

///Vector3 tempVect;


//Debug.Log(coinParent.transform.childCount);


//}
//if(Input.GetKeyDown(KeyCode.RightArrow))          
//{
//    moveDir = Vector2.right;
//}
//if (Input.GetKeyDown(KeyCode.LeftArrow))
//{
//    moveDir = Vector2.left;
//}
//if (Input.GetKeyDown(KeyCode.UpArrow))
//{
//    moveDir = Vector2.up;
//}
//if (Input.GetKeyDown(KeyCode.DownArrow))
//{
//    moveDir = Vector2.down;
//}

//if (Input.GetKeyDown(KeyCode.UpArrow))
//{ 
//    tempVect = new Vector3(0,speed,0);
//    tempVect = tempVect * speed * Time.deltaTime;
//    rigidbody2D.MovePosition(transform.position + tempVect);
//}

//if (Input.GetKeyDown(KeyCode.DownArrow))
//{
//    tempVect = new Vector3(0, -speed, 0);
//    tempVect = tempVect * speed * Time.deltaTime;
//    rigidbody2D.MovePosition(transform.position + tempVect);
//}



//moveDiraction.x = Input.GetAxisRaw("Horizontal");
//moveDiraction.y = Input.GetAxisRaw("Vertical");





//speedX = new Vector2(0, speed);

//Vector3 input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);

// rigidbody2D.MovePosition(transform.position + input * Time.deltaTime * speed);

//if (Input.GetKey(KeyCode.RightArrow))
//{
//    rigidbody2D.velocity = Vector2.zero;
//    rigidbody2D.velocity = new Vector2(speed * Time.deltaTime, 0);
//    //rigidbody2D.velocity = Vector2.right * speed * Time.deltaTime;
//    //rigidbody2D.MovePosition(transform.position + )
//}

//if (Input.GetKey(KeyCode.LeftArrow))
//{
//    //rigidbody2D.MovePosition(rigidbody2D.position - speedX);
//    rigidbody2D.velocity = Vector2.zero;

//    rigidbody2D.velocity = new Vector2(-speed * Time.deltaTime, 0);
//    //rigidbody2D.velocity = -Vector2.right * speed * Time.deltaTime;

//}
//if (Input.GetKey(KeyCode.UpArrow))
//{
//    //rigidbody2D.velocity = Vector2.up * speed * Time.deltaTime;
//    rigidbody2D.velocity = Vector2.zero;

//    rigidbody2D.velocity = new Vector2(0, speed * Time.deltaTime);
//}

//if (Input.GetKey(KeyCode.DownArrow))
//{
//    rigidbody2D.velocity = Vector2.zero;

//    //rigidbody2D.velocity = -Vector2.up * speed * Time.deltaTime;
//    rigidbody2D.velocity = new Vector2(0, -speed * Time.deltaTime);
//}

//rigidbody2D.velocity = Vector2.up * vertical * speed * Time.deltaTime;
//rigidbody2D.velocity = Vector2.right * horizontal * 300 * Time.deltaTime;
//transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
//transform.Translate(Vector3.up * vertical * speed * Time.deltaTime);
