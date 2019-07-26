using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Pepsiman : Set_Status
{

    public Pepsiman()
    {

        base.setName("Pepsiman");
        base.setHP(1300);
        base.setAT(50);
        base.setDF(50);
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
        Vector3 rote = myTransform.eulerAngles;
        base.setposition(pos);
        base.setrotetion(rote);


    }


}