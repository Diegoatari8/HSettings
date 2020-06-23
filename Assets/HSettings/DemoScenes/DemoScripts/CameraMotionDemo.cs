using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotionDemo : MonoBehaviour
{
    Vector3 center = new Vector3(0, 0, -4.3f);
 
    void Update()
    {
        transform.RotateAround(center, Vector3.up, 30 * Time.deltaTime);
    }
}
