using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCoroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ����һ��Э�̣�Э�̺���ΪTimer
        //StartCoroutine(Timer());
    }
    // Э�̺���
    IEnumerator Timer()
    {
        // ����ѭ��ִ�У����ǲ����ᵼ����ѭ��
        while(true)
        {
            // ��ӡ4������
            Debug.Log("����Э��");
            // �ȴ�1��
            yield return new WaitForSeconds(1);
            // ��ӡ��ǰ��Ϸ������ʱ��
            Debug.Log(Time.time);
            // �ٵȴ�1��
            yield return new WaitForSeconds(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
