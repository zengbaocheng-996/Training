using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyIter3 : MonoBehaviour
{
    IEnumerator<int> HelloWorld()
    {
        // �ֲ�������ֵ�ᱻ����
        float helloTime = 0;
        transform.position = new Vector3(1, 0, 0);
        // ��ʱ1��
        helloTime = Time.time + 1;
        while(Time.time<helloTime)
        {
            // �������ֵû���õ�
            yield return 1;
        }

        transform.position = new Vector3(2, 0, 0);
        // ��ʱ2��
        helloTime = Time.time + 2;
        while(Time.time<helloTime)
        {
            // �������ֵû���õ�
            yield return 2;
        }

        transform.position = new Vector3(3, 0, 0);
        helloTime = Time.time + 1;
        while (Time.time < helloTime)
        {
            yield return 1;
        }
    }
    IEnumerator<int> e;
    // Start is called before the first frame update
    void Start()
    {
        e = HelloWorld();
    }

    // Update is called once per frame
    void Update()
    {
        if(e!=null)
        {
            if(!e.MoveNext())
            {
                // Э�̽�����
                e = null;
                return;
            }
        }
    }
}
