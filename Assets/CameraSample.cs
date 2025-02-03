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
        //プレイヤーの情報を取得
        this.player = GameObject.Find("Player");

        // MainCamera(自分自身)とplayerとの相対距離を求める
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーの情報を取得
        this.player = GameObject.Find("Player");

        //新しいトランスフォームの値を代入する
        transform.position = player.transform.position + offset;

        //左シフトが押されている時
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //ユニティちゃんを中心に左回転
            transform.RotateAround(player.transform.position, Vector3.up, -0.1f);
        }
        //右シフトが押されている時
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //ユニティちゃんを中心に右回転
            transform.RotateAround(player.transform.position, Vector3.up, 0.1f);
        }
    }
}
