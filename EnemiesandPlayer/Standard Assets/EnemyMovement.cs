using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour 
{
    public int computerSpeed = 40;
    public int computerDirection;
    public Transform Fluffy;
    Vector2 moveDirection = Vector2.zero;
    Vector2 newPosition = Vector2.zero;
 


	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        Vector2 newPosition = new Vector2(0, 0, 0) * (moveSpeed * Time.deltaTime);
        newPosition = transform.position + newPosition;
        newPosition.x = Mathf.Clamp(newPosition.x, -101, 126);
        transform.position = newPosition;
	}
}
