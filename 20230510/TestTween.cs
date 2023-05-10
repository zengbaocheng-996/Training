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
        //    // 1秒时间移动到在x轴上坐标为5的位置上
        //    transform.DOMoveX(5, 1);

        //}
        //if(Input.GetKeyDown(KeyCode.A))
        //{
        //    // 1秒时间移动到在x轴上坐标为0的位置上
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
            //// 创建时间序列
            //Sequence seq = DOTween.Sequence();
            //// 添加动画到序列中
            //seq.Append(transform.DOMove(new Vector3(3, 4, 5), 2));
            //// 添加时间间隔
            //seq.AppendInterval(1);
            //seq.Append(transform.DOMove(new Vector3(0, 0, 0), 1));
            //// 按时间插入动画
            //// 下面代码的第一个参数为时间，表示插入动画到规定的时间点
            //seq.Insert(0, transform.DORotate(new Vector3(0, 90, 0), 1));

            // 两个动画同时播放，向斜上方移动
            //Tweener t = transform.DOMoveX(10, 1);
            //t.SetEase(Ease.OutQuad);
            //transform.DOMoveY(10, 1);

            // 播放
            transform.DOPlay();
            // 暂停
            transform.DOPause();
            // 重播
            transform.DORestart();
            // 倒播，此方法会直接退回起始点
            transform.DORewind();
            // 删除动画
            transform.DOKill();
            // 跳转到指定时间点。参数1表示跳转的时间点，参数2表示是否立即播放
            transform.DOGoto(1.5f, true);
            // 倒向播放动画
            transform.DOPlayBackwards();
            // 正向播放动画
            transform.DOPlayForward();

            // 动画完成回调，为方便起见回调函数写成了Lambda表达式
            transform.DOMove(new Vector3(3, 3, 0), 2).OnComplete(() => {
                Debug.Log("Tween 播放完成");
            });
            // 无限循环震动
            Tween t2 = transform.DOShakePosition(1, new Vector3(2, 0, 0));
            t2.SetLoops(-1);
            // 每次循环完成时回调
            transform.DOMove(Vector3.zero, 2).OnStepComplete(() => {
                Debug.Log("Tween 单次播放完成");
            });
        }
    }
}
