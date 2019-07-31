using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalcScript : MonoBehaviour {

    public GameObject Script1;
    public GameObject Script2;

    public Vector3 P1_Pos;
    public Vector3 P2_Pos;
    public float P1_HP;
    public float P2_HP;
    public float P1_AT;
    public float P2_AT;
    public float P1_DF;
    public float P2_DF;
    public int P1_State;
    public int P2_State;

    private float r1 = 2.0f;
    private float r2 = 2.0f;
    private float diff_x = 0.0f;
    private float diff_z = 0.0f;
    private float distance;
    private bool timeflag = false;
    private float time = 0.0f;


    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        P1_Pos = Script1.GetComponent<Config1pScript>().Player1_Pos;
        P2_Pos = Script2.GetComponent<Config2pScript>().Player2_Pos;

        P1_State = Script1.GetComponent<Config1pScript>().Player1_State;
        P2_State = Script2.GetComponent<Config2pScript>().Player2_State;

        P1_HP = Script1.GetComponent<Config1pScript>().Player1_HP;
        P1_AT = Script1.GetComponent<Config1pScript>().Player1_AT;
        P1_DF = Script1.GetComponent<Config1pScript>().Player1_DF;

        P2_HP = Script2.GetComponent<Config2pScript>().Player2_HP;
        P2_AT = Script2.GetComponent<Config2pScript>().Player2_AT;
        P2_DF = Script2.GetComponent<Config2pScript>().Player2_DF;

        diff_x = P2_Pos.x - P1_Pos.x;
        diff_z = P2_Pos.z - P1_Pos.z;
        distance = Mathf.Sqrt((diff_x * diff_x) + (diff_z * diff_z));

        if((P1_State != 0 || P2_State != 0) && distance < r1 + r2 && timeflag == false)
        {
            Debug.Log("ちんちん");
            timeflag = true; //timeを起動

            if(P1_State != 0)
            {
                switch (P1_State)
                {
                    case 1: P2_HP -= (P1_AT * 3 - P2_DF);
                        time = 2.0f;
                        break;
                    case 2: P2_HP -= (P1_AT * 4 - P2_DF);
                        time = 3.0f;
                        break;
                    case 3: P2_HP -= (P1_AT * 5 - P2_DF);
                        time = 3.0f;
                        break;
                    case 4: P2_HP -= (P1_AT * 6 - P2_DF);
                        time = 4.0f;
                        break;
                    default: break;
                }
                Script2.GetComponent<Config2pScript>().script.Player_Damagedown();
                P1_State = 0;
                
            }

            if(P2_State != 0)
            {
                switch (P2_State)
                {
                    case 1: P1_HP -= (P2_AT * 3 - P1_DF);
                        time = 2.0f;
                        break;
                    case 2: P1_HP -= (P2_AT * 4 - P1_DF);
                        time = 3.0f;
                        break;
                    case 3: P1_HP -= (P2_AT * 5 - P1_DF);
                        time = 3.0f;
                        break;
                    case 4: P1_HP -= (P2_AT * 6 - P1_DF);
                        time = 4.0f;
                        break;
                    default: break;
                }
                Script1.GetComponent<Config1pScript>().script.Player_Damagedown();
                P2_State = 0;
            }

        }

        if (timeflag != false)
        {
            time -= Time.deltaTime;
        }
        if (time <= 0)
        {
            timeflag = false;

        }


	}

    
}
