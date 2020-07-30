using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private GameObject Player;  // プレイヤーの情報
    private Vector3 Offset;         // 相対距離

    // Start is called before the first frame update
    void Start()
    {
        // プレイヤーの情報を格納
        Player = GameObject.Find("player");

        // 相対距離を格納
        Offset = new Vector3(0.0f, 10.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤーの位置と同期
        transform.position = Player.transform.position + Offset;
    }
}
