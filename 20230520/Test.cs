using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    IEnumerator LoadFileAsync()
    {
        string path = "";
        AssetBundleCreateRequest request = AssetBundle.LoadFromFileAsync(path);
        yield return request;
        AssetBundle ab = request.assetBundle;
        Instantiate(ab.LoadAsset<GameObject>("CubeWall"));
    }
    IEnumerator UseUnityWebRequest(string path)
    {
        // ʹ��UnityWebRequest.GetAssetBundle(·��)������Դ�����·������Դ��ַURL��ͬ��Ҳ֧�ֱ����ļ�
        UnityWebRequest request = UseUnityWebRequest.GetAssetBundle(path);
        yield return request.SendWebRequest();
        // ���е�������������ɣ���request�����л���ʲ���
        AssetBundle ab = DownloadHandlerAssetBundle.GetContent(request);
        // ֮���ʹ�÷����뱾�ؼ���û������
        GameObject obj = ab.LoadAsset<GameObject>("Wall");
        Instantiate(obj);
    }
}
