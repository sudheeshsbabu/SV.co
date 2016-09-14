using UnityEngine;
using System.Collections;

public class playemovement : MonoBehaviour
{
    public bool canMove=false;
    public float moveSpeed;
    public GameObject deathParticles;
	public GameObject cube;
    private float maxSpeed = 5f;
    public Vector3 input;
   
   
    private Vector3 spawn;

    // Use this for initialization
    void Start()
    {
        spawn = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

            if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
            { GetComponent<Rigidbody>().AddForce(input * moveSpeed); }

        }
      
        
     /*   if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3.Lerp(transform.position, transform.position += new Vector3(-1, 0, 0), maxSpeed);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
               Vector3.Lerp(transform.position, transform.position += new Vector3(1, 0, 0), maxSpeed);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3.Lerp(transform.position, transform.position += new Vector3(0,0,1), maxSpeed);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3.Lerp(transform.position, transform.position += new Vector3(0, 0,-1), maxSpeed);
        }*/

        if(transform.position.y<-2)
           die();
        

    }
    void OnCollisionEnter(Collision other)
    {
     if (other.transform.tag =="enemy")
        {
            die(); 

        
           // CharacterController cc = GetComponent<CharacterController>();
           // cc.enabled = false;
        }
        
  
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag =="goal")
        {
            gameobjects.completelevel();
        }

    }
    
    void die()
	{	Instantiate (cube, transform.position, Quaternion.Euler (0, 0, 0));
        //Instantiate(deathParticles, transform.position, Quaternion.Euler(-90, 90, 90));
      transform.position = spawn;
    }

}
