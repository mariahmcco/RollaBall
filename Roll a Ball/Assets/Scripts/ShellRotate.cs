using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellRotate : MonoBehaviour
{
       void Update()
    {
        transform.Rotate (new Vector3 (0, 25, 10) * Time.deltaTime);
    }
}
