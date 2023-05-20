using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLoadAB : MonoBehaviour
{
    void Start()
    {
        // 从文件中加载到AssetBundles
        AssetBundle ab = AssetBundle.LoadFromFile("D:/AssetBundles/ab");
        // 分别加载4个预制体资源
        GameObject prefab1 = ab.LoadAsset<GameObject>("Cube");
        GameObject prefab2 = ab.LoadAsset<GameObject>("Sphere");
        GameObject prefab3 = ab.LoadAsset<GameObject>("icon1");
        GameObject prefab4 = ab.LoadAsset<GameObject>("icon2");
        // 以上4句话可以用下面一句话代替，它会查找所有预制体，返回所有预制体组成的数组
        //GameObject[] prefabs = ab.LoadAllAssets<GameObject>();
        Instantiate(prefab1, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(prefab2, new Vector3(1, 0, 0), Quaternion.identity);
        Instantiate(prefab3, new Vector3(2, 0, 0), Quaternion.identity);
        Instantiate(prefab4, new Vector3(3, 0, 0), Quaternion.identity);
    }
}
