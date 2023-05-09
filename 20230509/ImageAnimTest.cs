using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI脚本要包含此命名空间
public class ImageAnimTest : MonoBehaviour
{
    Image image;
    // 可以在编辑器里指定另一张图片
    public Sprite otherSprite;
    float fillAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
        // 获取Image组件
        image = GetComponent<Image>();
        // 直接将图片换为另一张图片
        if(otherSprite!=null)
        {
            image.sprite = otherSprite;
        }
        // 将图片类型改为Filled，360度填充，方便制作旋转动画
        image.type = Image.Type.Filled;
        image.fillMethod = Image.FillMethod.Radial360;
    }

    // Update is called once per frame
    void Update()
    {
        // 制作一个旋转显示的动画效果，直线效果也是类似的
        // 取值为0~1
        image.fillAmount = fillAmount;
        fillAmount += 0.0002f;
        if(fillAmount>1)
        {
            fillAmount = 0;
        }
    }
}
