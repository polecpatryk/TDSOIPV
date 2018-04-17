using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    private float 
        deltaTime = 0.0f,
        msec = 0.0f,
        fps = 0.0f;

    private GUIStyle style;
    private Rect rect;

    void Start()
    {
        style = new GUIStyle();
        rect = new Rect(0, 0, Screen.width, Screen.height * 2 / 100);
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = Screen.height * 2 / 50;
        style.normal.textColor = new Color(0.0f, 0.0f, 0.5f, 1.0f);
    }

    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
    }

    void OnGUI()
    {
        msec = deltaTime * 1000.0f;
        fps = 1.0f / deltaTime;

        GUI.Label(rect, string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps), style);
    }
}