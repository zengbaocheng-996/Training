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
        // ����centerOfMass�Ϳ���ָ�������ˣ���������ϵ��
        rigid.centerOfMass = new Vector3(0, -1, 0);
        // �������е����ź���ת
        rigid.constraints = RigidbodyConstraints.FreezeAll;
        // ��������x���λ�ƣ�ȡ����������Լ��
        rigid.constraints = RigidbodyConstraints.FreezePositionX;
        // ������������ת��ȡ��λ��Լ��
        rigid.constraints = RigidbodyConstraints.FreezeRotation;
        // ������x���z�����ת��������y���λ��
        rigid.constraints = RigidbodyConstraints.FreezeRotationX
        | RigidbodyConstraints.FreezeRotationZ
        | RigidbodyConstraints.FreezePositionY;
    }

    public enum ForceMode
    {
        // Ĭ�Ϸ�ʽΪ����ʩ����������ţ����ѧ
        Force=0,
        // ����Ϊ˲�䱬�������ʺϱ��ֿ������ҵ��������籬ը
        // ���ĳ���ʱ�������𣬵���Ȼ����ţ����ѧ
        Impulse=1,
        // ˲��ı�����ٶȣ���������������
        VelocityChange=2,
        // ֱ�Ӹı���ٶȣ���������������
        Acceleration=5,
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
