using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // ������ʼ�¼�OnTriggerEnter������Ϊ��ײ����Ϣ������һ�������˸ô���������������ײ��
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " ��������");
        // �����Լ�
        Destroy(gameObject);
    }
}
