// v�ǵ���Ŷ�Ҳ�v��iŶ�˱�ŶŶ��
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutipleMaterialSaneLevel : MonoBehaviour {

    public Material lastMat;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (lastMat != null)
            {
                Material[] originalMtas = GetComponent<Renderer>().materials;
                for (int i = 0; i < originalMtas.Length; i++)
                {
                    originalMtas[i] = lastMat;
                }

                // 必须将赋值完之后的Material数组赋值回去，否则不起作用
                GetComponent<Renderer>().materials = originalMtas;
            }
        }
    }
}
