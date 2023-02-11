using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSize : MonoBehaviour
{
    [SerializeField]
    private int Screen_Width = 1024;
    [SerializeField]
    private int Screen_Height = 600;
    [SerializeField]
    private bool IsFullScreen = false;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(Screen_Width, Screen_Height, IsFullScreen, 60);
    }
}
