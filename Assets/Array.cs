using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // �z�������������
        int[] points = { 10, 20, 30, 40, 50 };

        // �z��̗v�f���̂Ԃ񂾂�1�������������J��Ԃ�
        for (int i = 0; i < points.Length; i++)
        {
            // �z��̗v�f��\������
            Debug.Log(points[i]);
        }
        // �z��̗v�f���̂Ԃ񂾂��P�����炷�������J��Ԃ�
        for (int i = 4; i >= 0; i--)
        {
            // �z��̗v�f��\������
            Debug.Log(points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}