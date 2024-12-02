using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSample : MonoBehaviour
{
    private GameObject player;   //プレイヤー情報格納用
    private Vector3 offset;      //相対距離取得用
    // Start is called before the first frame update
    void Start()
    {
        //unitychanの情報を取得
        this.player = GameObject.Find("Player");

        // MainCamera(自分自身)とplayerとの相対距離を求める
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //新しいトランスフォームの値を代入する
        transform.position = player.transform.position + offset;

        //左シフトが押されている時
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //ユニティちゃんを中心に-5f度回転
            transform.RotateAround(player.transform.position, Vector3.up, -0.5f);
        }
        //右シフトが押されている時
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //ユニティちゃんを中心に5f度回転
            transform.RotateAround(player.transform.position, Vector3.up, 0.5f);
        }
    }
}
