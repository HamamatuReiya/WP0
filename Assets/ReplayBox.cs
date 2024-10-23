using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayBox : MonoBehaviour
{
    [SerializeField]
    [Tooltip("ボックスのプレハブを設定")]
    private GameObject boxPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 設定したplayerPrefabと同じ名前(今回は"PlayerSphere")のGameObjectを探して取得
        GameObject boxObj = GameObject.Find(boxPrefab.name);

        // playerObjが存在していない場合
        if (boxObj == null)
        {
            // playerPrefabから新しくGameObjectを作成
            GameObject newBoxObj = Instantiate(boxPrefab);

            // 新しく作成したGameObjectの名前を再設定(今回は"PlayerSphere"となる)
            newBoxObj.name = boxPrefab.name;
            // ※ここで名前を再設定しない場合、自動で決まる名前は、"PlayerSphere(Clone)"となるため
            //   13行目で探している"PlayerSphere"が永遠に見つからないことになり、playerが無限に生産される
            //   どういうことかは、22行目をコメントアウトしてゲームを実行すればわかります。
        }
    }
}
