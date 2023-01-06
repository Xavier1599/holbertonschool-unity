using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, 45 * Time.deltaTime);
    }
}
