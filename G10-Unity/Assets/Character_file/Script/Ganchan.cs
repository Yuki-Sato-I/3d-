using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Ganchan : Set_Status
{

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
        Vector3 rote = myTransform.eulerAngles;
        base.setposition(pos);
        base.setrotetion(rote);


    }
}