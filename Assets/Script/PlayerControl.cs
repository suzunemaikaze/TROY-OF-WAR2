using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    public Vector3 latestPos;  //前回のPosition
    public float smooth;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Vector3 force = new Vector3(0.0f, 0.0f, speed);    // 力を設定
            if(force.magnitude > 0.1f)
            {
                //体の向きを変更
                Quaternion rotation = Quaternion.LookRotation(force);
                transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * smooth);
            }
            rb.AddForce(force);  // 力を加える
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 force = new Vector3(-speed, 0.0f, 0.0f);    // 力を設定
            if (force.magnitude > 0.1f)
            {
                //体の向きを変更
                Quaternion rotation = Quaternion.LookRotation(force);
                transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * smooth);
            }
            rb.AddForce(force);  // 力を加える
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 force = new Vector3(0.0f, 0.0f, -speed);    // 力を設定
            if (force.magnitude > 0.1f)
            {
                //体の向きを変更
                Quaternion rotation = Quaternion.LookRotation(force);
                transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * smooth);
            }
            rb.AddForce(force);  // 力を加える
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 force = new Vector3(speed, 0.0f, 0.0f);    // 力を設定
            if (force.magnitude > 0.1f)
            {
                //体の向きを変更
                Quaternion rotation = Quaternion.LookRotation(force);
                transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * smooth);
            }
            rb.AddForce(force);  // 力を加える
        }

    }
    
    void FixedUpdate()
    {
        // AddForceで生まれた慣性を無くす
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
    
}
