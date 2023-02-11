using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutOfScreen : MonoBehaviour
{
    [SerializeField]
    private GameObject Object;

    private RectTransform ObjectRect;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("スクリーンWidth:"+Screen.width+"   スクリーンHeight:"+Screen.height);

        ObjectRect = Object.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if((0.0f <= ObjectRect.position.x && ObjectRect.position.x <= Screen.width) && (0.0f <= ObjectRect.position.y && ObjectRect.position.y <= Screen.height))
        {
            Debug.Log("画面内");
            Object.SetActive (true);
        }
        else
        {
            Debug.Log("画面外");
            Object.SetActive (false);
        }
    }
}
