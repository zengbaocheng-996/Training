using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //// ������ԭ�����ϵ�����
        //Ray ray = new Ray(Vector3.zero, Vector3.up);
        //// ��õ�ǰ���ָ������Ļ�ϵ�λ�ã���λ�����أ�
        //Vector2 mousePos = Input.mousePosition;
        //// ����һ�����ߣ�����������λ�ã�����ָ�����ָ�����ڵĵ㣨�����˴���Ļ�����������ת����
        //Ray ray2 = Camera.main.ScreenPointToRay(mousePos);
        //// ֮����Խ�ray��ray2�����ȥ�����磺
        //Physics.Raycast(ray, 10000, LayerMask.GetMask("Default"));
        int mask = LayerMask.GetMask("Ground", "Player", "Obstacle");
        mask = ~mask; // Ӣ�Ĳ����ߣ����������ȡ��
        gameObject.layer = LayerMask.NameToLayer("Default");
        if(Physics.Raycast(transform.position,Vector3.forward,mask))
        { 
            // ����������
        }
    }
    private void TestRayHit()
    {
        // �������������ڱ�����ײ��Ϣ
        RaycastHit hitInfo;
        // �������ߣ�����ǵ�ǰ�����λ�ã�����������ǰ��
        if(Physics.Raycast(transform.position,Vector3.forward,out hitInfo))
        {
            // ���ȷʵ�������壬�����е����û��������Ͳ���

            // ��ȡ��ײ������꣨�������꣩
            Vector3 point = hitInfo.point;
            // ��ȡ�Է�����ײ�����
            Collider coll = hitInfo.collider;
            // ��ȡ�Է���Transform���
            Transform trans = hitInfo.transform;
            // ��ȡ�Է�����������
            string name = coll.gameObject.name;
            // ��ȡ��ײ��ķ�������
            Vector3 normal = hitInfo.normal;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
