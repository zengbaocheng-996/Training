using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    // ׷�ٵ�Ŀ�꣬�ٱ༭����ָ��
    public Transform followTarget;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        // �����Ŀ�굽���������������Ϊ�������ƫ����
        offset = transform.position - followTarget.position;
    }
    void LateUpdate()
    {
        // ÿ֡�����������λ��
        transform.position = followTarget.position + offset;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
