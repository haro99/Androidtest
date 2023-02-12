using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobilecontroller : MonoBehaviour
{
    public Rigidbody Rb;

    // Start is called before the first frame update
    void Start()
    {
        Rb.WakeUp();
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion gyro = Input.gyro.attitude;

        transform.rotation = new Quaternion(-gyro.y, gyro.z, -gyro.y, gyro.w);
    }
}
