using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGetGameObject : MonoBehaviour
{
    GameObject objMainCam;
    GameObject objMainLight;
    // Start is called before the first frame update
    void Start()
    {
        objMainCam = GameObject.Find("Main Camera");
        objMainLight = GameObject.Find("Directional Light");
        Debug.Log("���������" + objMainCam.name);
        Debug.Log("����Դ��" + objMainLight.name);
        // ���������������������1�׵�λ��
        objMainCam.transform.position = transform.position - transform.forward;

        // ���ҵ�һ����ǩΪPlayer������
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        // �������б�ǩΪMonster�����壬ע�ⷵ��ֵ��һ�����飬���������0������
        GameObject[] monsters = GameObject.FindGameObjectsWithTag("Monster");

        // ���ĳ��Player����
        GameObject m = GameObject.FindGameObjectWithTag("Player");
        // �����ı�ǩ����ΪCube
        m.tag = "Cube";
        // �ж�m�ı�ǩ�ǲ���Cube
        if (m.CompareTag("Cube")) 
        {
        }
        // �����CompareTag�÷��ȼ���m.tag=="Cube",�Ƽ�ʹ��CompareTag
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
