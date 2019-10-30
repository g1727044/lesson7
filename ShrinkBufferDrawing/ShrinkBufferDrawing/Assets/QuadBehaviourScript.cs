using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadBehaviourScript : MonoBehaviour
{
    void Start()
    {
        Camera cam = Camera.main;
        // 位置の調整
        float distance = cam.farClipPlane - 10.0f;
        transform.localPosition = new Vector3(0, 0, distance);
        transform.localRotation = new Quaternion();
        // 画面にピッタリ一致するようにカメラからの距離から大きさを逆算
        float inv_aspect = (float)Screen.width / (float)Screen.height;
        float s = Mathf.Tan(0.5f * cam.fieldOfView * Mathf.Deg2Rad) * 2.0f * distance;
        transform.localScale = new Vector3(inv_aspect * s + 30, s + 20, 1);
    }

    void Update()
    {
        
    }
}
