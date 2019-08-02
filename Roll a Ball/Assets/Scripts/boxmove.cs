using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxmove : MonoBehaviour
{
    private Vector3 startPosition;
    public float speed;

    void Start () 
    {
      
        startPosition = transform.position;
    }

    void Update()
    {

        transform.position = new Vector3(startPosition.x + Mathf.Sin(Time.time * speed), transform.position.y, transform.position.z);
    
    
    }
}
