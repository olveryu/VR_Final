﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Survey_Handler : MonoBehaviour
{

    public GameObject dlog;
    public dataLog dscript;

    public GameObject leftHand;
    public GameObject rightHand;
    public string lhName;
    public string rhName;


    // Use this for initialization
    void Start()
    {

        lhName = leftHand.name;
        rhName = rightHand.name;
        dscript = dlog.GetComponent<dataLog>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.name.Equals(rhName) || col.gameObject.name.Equals(lhName))
        {
            Debug.Log("You have selected " + this.gameObject.name);
            //store some data!!!!!!!!!!!!!!
        }
    }
}
