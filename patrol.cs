using UnityEngine;
using System.Collections;

public class patrol : MonoBehaviour {
    public Transform[] patrolpoint;
    private int currentPoint;
    public float moveSpeed;
	// Use this for initialization
	void Start () {
      
        currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position == patrolpoint[currentPoint].position)
        {
            currentPoint++;
        }
        if (currentPoint >=patrolpoint.Length)
        {
            currentPoint = 0;
        }
        transform.position = Vector3.MoveTowards(transform.position, patrolpoint[currentPoint].position, moveSpeed * Time.deltaTime);
	}
  
}
