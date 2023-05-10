using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class TestTween : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    // 1��ʱ���ƶ�����x��������Ϊ5��λ����
        //    transform.DOMoveX(5, 1);

        //}
        //if(Input.GetKeyDown(KeyCode.A))
        //{
        //    // 1��ʱ���ƶ�����x��������Ϊ0��λ����
        //    transform.DOMoveX(0, 1);
        //}
        //if(Input.GetKeyDown(KeyCode.A))
        //{
        //    Tweener t = transform.DOMoveX(10, 1);
        //    t.SetEase(Ease.OutQuad);
        //}
        //if(Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.DOMoveX(0, 1).SetEase(Ease.InOutSine);
        //}

        if (Input.GetKeyDown(KeyCode.D))
        {
            //// ����ʱ������
            //Sequence seq = DOTween.Sequence();
            //// ��Ӷ�����������
            //seq.Append(transform.DOMove(new Vector3(3, 4, 5), 2));
            //// ���ʱ����
            //seq.AppendInterval(1);
            //seq.Append(transform.DOMove(new Vector3(0, 0, 0), 1));
            //// ��ʱ����붯��
            //// �������ĵ�һ������Ϊʱ�䣬��ʾ���붯�����涨��ʱ���
            //seq.Insert(0, transform.DORotate(new Vector3(0, 90, 0), 1));

            // ��������ͬʱ���ţ���б�Ϸ��ƶ�
            //Tweener t = transform.DOMoveX(10, 1);
            //t.SetEase(Ease.OutQuad);
            //transform.DOMoveY(10, 1);

            // ����
            transform.DOPlay();
            // ��ͣ
            transform.DOPause();
            // �ز�
            transform.DORestart();
            // �������˷�����ֱ���˻���ʼ��
            transform.DORewind();
            // ɾ������
            transform.DOKill();
            // ��ת��ָ��ʱ��㡣����1��ʾ��ת��ʱ��㣬����2��ʾ�Ƿ���������
            transform.DOGoto(1.5f, true);
            // ���򲥷Ŷ���
            transform.DOPlayBackwards();
            // ���򲥷Ŷ���
            transform.DOPlayForward();

            // ������ɻص���Ϊ��������ص�����д����Lambda���ʽ
            transform.DOMove(new Vector3(3, 3, 0), 2).OnComplete(() => {
                Debug.Log("Tween �������");
            });
            // ����ѭ����
            Tween t2 = transform.DOShakePosition(1, new Vector3(2, 0, 0));
            t2.SetLoops(-1);
            // ÿ��ѭ�����ʱ�ص�
            transform.DOMove(Vector3.zero, 2).OnStepComplete(() => {
                Debug.Log("Tween ���β������");
            });
        }
    }
}
