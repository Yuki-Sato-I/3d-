using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour {

    public void OnClickStartButton() {

        Debug.Log("aaaaaa");


        //ここで音とかアクションとか出せれば最高

        //キャラクター選択画面に移動
        SceneManager.LoadScene("CharacterSelectScene");
    }
}
