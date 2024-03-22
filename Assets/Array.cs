using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // 配列を初期化する
        int[] points = { 10, 20, 30, 40, 50 };

        // 配列の要素数のぶんだけ1ずつ足す処理を繰り返す
        for (int i = 0; i < points.Length; i++)
        {
            // 配列の要素を表示する
            Debug.Log(points[i]);
        }
        // 配列の要素数のぶんだけ１ずつ減らす処理を繰り返す
        for (int i = 4; i >= 0; i--)
        {
            // 配列の要素を表示する
            Debug.Log(points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}