using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TexturesAssetsStore : ScriptableObject
{
    public Texture2D[] TexturesAssets;

    /// <summary>
    /// 获取随机的UI图片
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public Texture2D[] GetTexture2Ds(int num)
    {
        if (num <= 0)
        {
            Debug.LogError("[TexturesAssetsStore] 请求的数据长度有误");
        }
        List<Texture2D> assetsList = TexturesAssets.ToList();
        if (num >= TexturesAssets.Length)
        {
            return assetsList.ToArray();
        }
        Texture2D[] tempAry = new Texture2D[num];
        for (int i = 0; i < num; i++)
        {
            Texture2D tex = RandomTex(assetsList);
            tempAry[i] = tex;
            assetsList.Remove(tex);
        }
        return tempAry;
    }

    /// <summary>
    /// 随机图片
    /// </summary>
    /// <param name="tempTexList"></param>
    /// <returns></returns>
    public Texture2D RandomTex(List<Texture2D> tempTexList)
    {
        if (tempTexList.Count <= 0)
        {
            throw new System.Exception("[TexturesAssetsStore] 图片数组为空，请检查数据");
        }
        if (tempTexList.Count == 1)
        {
            return tempTexList[0];
        }
        int idx = Random.Range(0, tempTexList.Count);
        return tempTexList[idx];
    }
}
