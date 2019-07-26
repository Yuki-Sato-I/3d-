using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinerDisplayScript : MonoBehaviour
{

    Text Winer;
    int winnerNum;
    string message = "";

    // Use this for initialization
    void Start()
    {
        Winer = GetComponentInChildren<Text>();//UIのテキストの取得の仕方
        winnerNum = MainGameScript.getWinnerNum();

        switch (winnerNum) {
            case 1:
                message = "~1P~";
                break;
            case 2:
                message = "~2P~";
                break;
            default:
                message = "不正な画面遷移";
                break;
        }
        StartCoroutine("Delay");
    }

    // Update is called once per frame
    void Update()
    {
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
        Winer.text = message;
        yield break;
    }
}
