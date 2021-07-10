using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
public class Goal
{
    [SerializeField]
    string objective = "";

    [SerializeField]
    Vector3 location = new Vector3(0, 0, 0);

    [SerializeField]
    int xp = 0;

    [SerializeField]
    bool isOptional = false;

    [SerializeField]
    bool isComplete = false;
}
