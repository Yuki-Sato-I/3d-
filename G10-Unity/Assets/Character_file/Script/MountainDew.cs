using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainDew : Set_Status
{

    public MountainDew()
    {

        base.setName("MountainDew");
        base.setHP(1000);
        base.setAT(70);
        base.setDF(20);

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