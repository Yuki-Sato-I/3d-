using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinerDisplayScript : MonoBehaviour
{

    Text Winer;

    // Use this for initialization
    void Start()
    {
        Winer = GetComponentInChildren<Text>();//UIのテキストの取得の仕方
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("A");
            Winer.text = "~1P~";
        }
        if (Input.GetKeyDown("space"))
        {
            print("space");
            Winer.text = "~2P~";
        }
    }
}
