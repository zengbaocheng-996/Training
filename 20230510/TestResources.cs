using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestResources : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*---������Դ---*/
        // Ԥ������Դ��GameObject���ͱ�ʾ��·����������Resources������չ��
        GameObject go = Resources.Load<GameObject>("Prefabs/Cube");
        // ��Դ���غ�ʵ�����ǲ�ͬ��
        GameObject go2 = Instantiate(go);
        // �����������͵���Դ
        Texture2D image = Resources.Load<Texture2D>("Image/1");
        Debug.Log("image.name");
        /*---ж����Դ---*/
        // ǿ��ж����Դ
        Resources.UnloadAsset(image);
        //��������
        Destroy(go2);
    }

}
