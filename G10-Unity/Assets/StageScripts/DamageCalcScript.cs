using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalcScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //ダメージ計算(攻撃する方、攻撃食らう方)
    public void CalcDamage(PlayerConfig attackPlayer,PlayerConfig defencePlayer) {
        Debug.Log(attackPlayer.HP);
        Debug.Log(defencePlayer.HP);
        //キックとパンチ区別余裕があった
        int damage = attackPlayer.AT * 3 - defencePlayer.DF;

        defencePlayer.HP -= damage;
    }
}
