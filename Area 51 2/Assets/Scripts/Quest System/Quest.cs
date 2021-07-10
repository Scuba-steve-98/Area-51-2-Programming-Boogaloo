using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Quest : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    [SerializeField]
    Vector3 location = new Vector3(0, 0, 0);

    [SerializeField]
    int xp = 0;

    [SerializeField]
    int noOfGoals = 1;

    [SerializeField]
    Goal[] goals;

    public virtual void setXP(int XP)
    {
        xp = XP;
    }
}
