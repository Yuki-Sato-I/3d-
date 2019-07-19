using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Ganchan : Set_Status{

    public Ganchan()
    {

        base.setName("Ganchan");
        base.setHP(1000);
        base.setAT(20);
        base.setDF(70);

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;
        base.setposition(myTransform.position);
        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            Player_Run(true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Player_Run(false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Player_Run(true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Player_Run(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Player_Run(true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Player_Run(false);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("うんちジャブ");
            Player_Jab(true);
        }
        */
    }
}
