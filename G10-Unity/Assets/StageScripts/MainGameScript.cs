using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameScript : MonoBehaviour {

    Config1pScript player1;
    Config2pScript player2;

    void Awake()
    {
        player1 = GameObject.Find("1pConfig").GetComponent<Config1pScript>();
        player2 = GameObject.Find("2pConfig").GetComponent<Config2pScript>();
    }


    void Start () {


        DamageCalcScript damage = GameObject.Find("DamageCalc").GetComponent<DamageCalcScript>();
        damage.CalcDamage(player1,player2);
        Debug.Log("---------------");
        Debug.Log(player1.HP);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
