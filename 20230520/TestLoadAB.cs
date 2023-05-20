using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLoadAB : MonoBehaviour
{
    void Start()
    {
        // ���ļ��м��ص�AssetBundles
        AssetBundle ab = AssetBundle.LoadFromFile("D:/AssetBundles/ab");
        // �ֱ����4��Ԥ������Դ
        GameObject prefab1 = ab.LoadAsset<GameObject>("Cube");
        GameObject prefab2 = ab.LoadAsset<GameObject>("Sphere");
        GameObject prefab3 = ab.LoadAsset<GameObject>("icon1");
        GameObject prefab4 = ab.LoadAsset<GameObject>("icon2");
        // ����4�仰����������һ�仰���棬�����������Ԥ���壬��������Ԥ������ɵ�����
        //GameObject[] prefabs = ab.LoadAllAssets<GameObject>();
        Instantiate(prefab1, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(prefab2, new Vector3(1, 0, 0), Quaternion.identity);
        Instantiate(prefab3, new Vector3(2, 0, 0), Quaternion.identity);
        Instantiate(prefab4, new Vector3(3, 0, 0), Quaternion.identity);
    }
}
