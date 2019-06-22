using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameScript : MonoBehaviour {


    public GameObject TestChar;
    public GameObject MountainDew;    //1
    public GameObject Pepsi;          //2
    public GameObject Ganchan;        //3
     
    void Start () {
        // プレハブを取得
        // プレハブからインスタンスを生成
        int NumOf1p = configScripts.GetPlayer1Num();
        int NumOf2p = configScripts.GetPlayer2Num();
        GameObject player1;
        GameObject player2;
        //1pのキャラ生成
        switch (NumOf1p) {
            case 1:
                player1 = Instantiate(MountainDew, new Vector3(-10f, 1, 0.0f), Quaternion.identity);
                break;
            case 2:
                player1 = Instantiate(Pepsi, new Vector3(-10f, 1, 0.0f), Quaternion.identity);
                break;
            case 3:
                player1 = Instantiate(Ganchan, new Vector3(-10f, 1, 0.0f), Quaternion.identity);
                break;
            default://デバック用
                player1 = Instantiate(TestChar, new Vector3(-10f, 1, 0.0f), Quaternion.identity);
                break;
        }
        //2pのキャラ生成
        switch (NumOf2p)
        {
            case 1:
                player2 = Instantiate(MountainDew, new Vector3(10f, 1, 0.0f), Quaternion.identity);
                break;
            case 2:
                player2 = Instantiate(Pepsi, new Vector3(10f, 1, 0.0f), Quaternion.identity);
                break;
            case 3:
                player2 = Instantiate(Ganchan, new Vector3(10f, 1, 0.0f), Quaternion.identity);
                break;
            default://デバック用
                player2 = Instantiate(TestChar, new Vector3(10f, 1, 0.0f), Quaternion.identity);
                break;
        }
        player1.name = "1pChar";
        player1.tag = "player1";
        player2.name = "2pChar";
        player2.tag = "player2";

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
