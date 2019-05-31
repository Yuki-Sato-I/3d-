using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour {
    public AudioClip startSe;

    public void OnClickStartButton() {

        StartCoroutine("CharChangeScene");

    }
    public IEnumerator CharChangeScene()
    {
        //ここで音
        GetComponent<AudioSource>().PlayOneShot(startSe);
        //2P選択時に余韻に浸る
        yield return new WaitForSeconds(2);
        //キャラクター選択画面に移動
        SceneManager.LoadScene("CharacterSelectScene");

    }
}
