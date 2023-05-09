using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI�ű�Ҫ�����������ռ�
public class ImageAnimTest : MonoBehaviour
{
    Image image;
    // �����ڱ༭����ָ����һ��ͼƬ
    public Sprite otherSprite;
    float fillAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
        // ��ȡImage���
        image = GetComponent<Image>();
        // ֱ�ӽ�ͼƬ��Ϊ��һ��ͼƬ
        if(otherSprite!=null)
        {
            image.sprite = otherSprite;
        }
        // ��ͼƬ���͸�ΪFilled��360����䣬����������ת����
        image.type = Image.Type.Filled;
        image.fillMethod = Image.FillMethod.Radial360;
    }

    // Update is called once per frame
    void Update()
    {
        // ����һ����ת��ʾ�Ķ���Ч����ֱ��Ч��Ҳ�����Ƶ�
        // ȡֵΪ0~1
        image.fillAmount = fillAmount;
        fillAmount += 0.0002f;
        if(fillAmount>1)
        {
            fillAmount = 0;
        }
    }
}
