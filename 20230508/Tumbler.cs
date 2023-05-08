using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tumbler : MonoBehaviour
{
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        // 设置centerOfMass就可以指定重心了（本地坐标系）
        rigid.centerOfMass = new Vector3(0, -1, 0);
        // 冻结所有的缩放和旋转
        rigid.constraints = RigidbodyConstraints.FreezeAll;
        // 仅冻结沿x轴的位移，取消所有其他约束
        rigid.constraints = RigidbodyConstraints.FreezePositionX;
        // 仅冻结所有旋转，取消位移约束
        rigid.constraints = RigidbodyConstraints.FreezeRotation;
        // 冻结沿x轴和z轴的旋转，冻结沿y轴的位移
        rigid.constraints = RigidbodyConstraints.FreezeRotationX
        | RigidbodyConstraints.FreezeRotationZ
        | RigidbodyConstraints.FreezePositionY;
    }

    public enum ForceMode
    {
        // 默认方式为持续施加力，符合牛顿力学
        Force=0,
        // 设置为瞬间爆发力，适合表现快速猛烈的力，例如爆炸
        // 力的持续时间有区别，但仍然符合牛顿力学
        Impulse=1,
        // 瞬间改变刚体速度，不考虑物体质量
        VelocityChange=2,
        // 直接改变加速度，不考虑物体质量
        Acceleration=5,
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
