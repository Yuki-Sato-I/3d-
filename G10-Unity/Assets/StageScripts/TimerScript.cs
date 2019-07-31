using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimerScript : MonoBehaviour {

    float limitTime = 60;
    private float P1_HP;
    private float P2_HP;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        limitTime -= Time.deltaTime;
        GetComponent<Text>().text = limitTime.ToString("F0");

        if(GetComponent<Text>().text == "0") {
            
            MainGameScript MainConfig = GameObject.Find("StageConfig").GetComponent<MainGameScript>();
            P1_HP = GameObject.Find("1pConfig").GetComponent<Config1pScript>().Player1_HP;
            P2_HP = GameObject.Find("2pConfig").GetComponent<Config2pScript>().Player2_HP;
            print(P1_HP);
            print(P2_HP);
            if (P1_HP > P2_HP)
            {
                MainConfig.winnerNum = 1;
            }
            else if (P1_HP == P2_HP)
            {
                MainConfig.winnerNum = 3;
            }
            else
			{
				MainConfig.winnerNum = 2;
			}

            StartCoroutine("delay");
        }
    }

    private IEnumerator delay()
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("ResultScene");

        yield break;
    }


}
