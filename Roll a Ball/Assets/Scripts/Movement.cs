using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 6;
        void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time*speed, 3), transform.position.y, transform.position.z);
    }
}
