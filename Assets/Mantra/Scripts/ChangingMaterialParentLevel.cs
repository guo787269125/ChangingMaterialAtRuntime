// v�ǵ���Ŷ�Ҳ�v��iŶ�˱�ŶŶ��
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingMaterialParentLevel : MonoBehaviour {

    private Material mat;

    void Start()
    {
        mat = Resources.Load<Material>("Red");
        print("Start");
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponentInChildren<Renderer>().material = mat;
        }
	}
}
