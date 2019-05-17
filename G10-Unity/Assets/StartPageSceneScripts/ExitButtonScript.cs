using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonScript : MonoBehaviour {

	// Use this for initialization
	public void OnClickExitButton () {
        Debug.Log("実行ファイル時に有効。Unity内では無効");
        Application.Quit();
    }

}
