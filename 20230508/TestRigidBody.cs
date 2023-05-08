using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRigidBody : MonoBehaviour
{
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        // 获取当前物体速度
        Vector3 vel = rigid.velocity;
        // 将当前速度沿z轴增加1m/s
        rigid.velocity = vel + new Vector3(0, 0, 1);
    }

    // Update is called once per frame
    private void Update()
    {
        //if(Input.GetButtonDown("Jump"))
        //{
        //    rigid.AddForce(new Vector3(0, 100, 1));
        //}
        if (Input.GetKeyDown(KeyCode.R))
        {
            rigid.angularVelocity = new Vector3(0, 60, 0);
        }
    }
}
