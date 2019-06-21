using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButtonScript : MonoBehaviour {
    public AudioClip startSe;
    public int count = 0;

    Button button;
    private void Start()
    {
        button = GetComponent<Button>();
    }
    public void OnClickStartButton() {

        button.interactable = false;
        count += 1;
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
