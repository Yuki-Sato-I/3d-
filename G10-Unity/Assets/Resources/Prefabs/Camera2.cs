using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour {

    GameObject Enemy;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Enemy = GameObject.FindWithTag("player1");
        Vector3 Enemy_Pos = Enemy.transform.position;
        Vector3 worldpos;
        Vector3 localpos;
        Vector3 worldangle;

        worldpos = myTransform.position;
        localpos = myTransform.localPosition;
        worldangle = myTransform.eulerAngles;

        if (Input.GetKey("u"))
        {
            worldangle.y = (Mathf.Atan2((Enemy_Pos.x - worldpos.x), (Enemy_Pos.z - worldpos.z))) * Mathf.Rad2Deg;
            localpos.x = -10.0f;    // ローカル座標を基準にした、x座標を1に変更
            localpos.y = 10.0f;    // ローカル座標を基準にした、y座標を1に変更
            localpos.z = 0.0f;    // ローカル座標を基準にした、z座標を1に変更
            myTransform.localPosition = localpos; // ローカル座標での座標を設定
        }
        else if (Input.GetKey("o"))
        {
            worldangle.y = (Mathf.Atan2((Enemy_Pos.x - worldpos.x), (Enemy_Pos.z - worldpos.z))) * Mathf.Rad2Deg;
            localpos.x = 10.0f;    // ローカル座標を基準にした、x座標を1に変更
            localpos.y = 10.0f;    // ローカル座標を基準にした、y座標を1に変更
            localpos.z = 0.0f;    // ローカル座標を基準にした、z座標を1に変更
            myTransform.localPosition = localpos; // ローカル座標での座標を設定
        }
        else
        {
            worldangle.y = (Mathf.Atan2((Enemy_Pos.x - worldpos.x), (Enemy_Pos.z - worldpos.z))) * Mathf.Rad2Deg;
            localpos.x = 0.0f;    // ローカル座標を基準にした、x座標を1に変更
            localpos.y = 10.0f;    // ローカル座標を基準にした、y座標を1に変更
            localpos.z = -10.0f;    // ローカル座標を基準にした、z座標を1に変更
            myTransform.localPosition = localpos; // ローカル座標での座標を設定
        }
        // ワールド座標を基準に、y軸を軸にした回転を10度に変更
        //worldAngle.z = 10.0f; // ワールド座標を基準に、z軸を軸にした回転を10度に変更
        myTransform.eulerAngles = worldangle; // 回転角度を設定
    }
}
