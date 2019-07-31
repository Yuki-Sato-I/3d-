using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameScript : MonoBehaviour {

    Config1pScript player1;
    Config2pScript player2;

    public int winnerNum;
    public static int num = 0;//一時的にwinnerの数字入れとくとこ

    void Awake()
    {
        player1 = GameObject.Find("1pConfig").GetComponent<Config1pScript>();
        player2 = GameObject.Find("2pConfig").GetComponent<Config2pScript>();
    }


    void Start () {

    }

    public static int getWinnerNum()
    {
        return num;
    }
    // Update is called once per frame
    void Update () {
        num = winnerNum;
	}
}
