using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestResources : MonoBehaviour
{
    private void Start()
    {
        /* ������Դ */
        // Ԥ������Դ��GameObject���ͱ�ʾ��·��������Resources����չ��
        GameObject go = Resources.Load<GameObject>("Prefabs/Cube");
        // ��Դ���غ�ʵ�����ǲ�ͬ��
        GameObject go2 = Instantiate(go,new Vector3(0,0,0),Quaternion.identity);

        //// �����������͵���Դ
        //Texture2D image = Resources.Load<Texture2D>("Images/1");
        //Debug.Log(image.name);

        ///* ж����Դ */
        //// ǿ��ж����Դ
        //Resources.UnloadAsset(image);
        //// ��������
        //Destroy(go2);

        //// ж��һ����Դ
        //public static void UnloadAsset(Object asssetToUnload);
        //// �Զ�ж������δʹ�õ���Դ
        //public static AsyncOperation UnloadUnusedAssets();
    }
}
