using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameScript : MonoBehaviour {



     
    void Start () {


        DamageCalcScript damage = GameObject.Find("damageCalc").GetComponent<DamageCalcScript>();
        damage.CalcDamage(GameObject.Find("1pConfig").GetComponent<Config1pScript>(),GameObject.Find("2pConfig").GetComponent<Config2pScript>());

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
