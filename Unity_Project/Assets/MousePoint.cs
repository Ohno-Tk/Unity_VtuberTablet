using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePoint : MonoBehaviour
{
    [SerializeField]
    private GameObject HandObject; // 手の画像オブジェクト

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Debug.Log("マウス X座標:"+mousePos.x+"    マウス Y座標:"+mousePos.y);
    }
}
