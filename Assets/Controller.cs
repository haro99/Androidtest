using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 加速度センサーは傾きの数値も取ってしまうので注意
 * */
public class Controller : MonoBehaviour
{
    public GameObject camerapos;
    private Vector3 acceleration;
    private Compass compass;
    private Quaternion gyro;

    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        this.acceleration = Input.acceleration;
        this.compass = Input.compass;
        this.gyro = Input.gyro.attitude;

        //// 加速度センサを利用してCubeを移動
        //float speed = 5.0f;

        //var dir = Vector3.zero;
        //dir.x = Input.acceleration.x;
        //dir.y = Input.acceleration.y;

        //if (dir.sqrMagnitude > 1)
        //{
        //    dir.Normalize();
        //}

        //dir *= Time.deltaTime;

        //transform.Translate(dir * speed);

        //ジャイロをそのまま代入
        //transform.rotation = new Quaternion(gyro.x, gyro.y, gyro.z, gyro.w);
        //ジャイロの数値を反転させて代入
        //transform.rotation = new Quaternion(-gyro.x, -gyro.y, gyro.z, gyro.w);
        //ジャイロに90度追加して代入
        transform.rotation = Quaternion.Euler(90f, 0f, 0f) * (new Quaternion(-gyro.x, -gyro.y, gyro.z, gyro.w));
    }
}
