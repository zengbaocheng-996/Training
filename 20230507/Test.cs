using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    SphereCollider collider;
    // Start is called before the first frame update
    void Start()
    {
        //// ��ȡ������󣬽��������ñ�����collider�ֶ��У������´�ʹ��
        //collider = gameObject.GetComponent<SphereCollider>();
        //// ����ÿһ��д����������һ��ȼ�
        //collider = this.GetComponent<SphereCollider>();
        //collider = GetComponent<SphereCollider>(); // ͬ�ϣ�ʡ����this
        //collider = transform.GetComponent<SphereCollider>(); // ͨ��transform�������������
        //collider = transform.GetComponent<MeshRenderer>().GetComponent<SphereCollider>();
        //collider = transform.GetComponent<SphereCollider>().GetComponent<SphereCollider>();
        //// ���һ�ٵ�д�������ǽ��Ҳ��ȷ
        collider = GetComponent<SphereCollider>();
        // ��ȡ�����еĽű����������������
        Test[] tests = GetComponents<Test>();
        Debug.Log(" ���� " + tests.Length + " ��Test�ű����");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
