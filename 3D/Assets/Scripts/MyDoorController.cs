﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDoorController : MonoBehaviour
{
    private Animator doorAnim;

    private bool doorOpen = false;

    private void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (!doorOpen)
        {
            doorAnim.Play("doorOpen", 0, 0.0f);
            doorOpen = true;
        }
        else
        {
            doorAnim.Play("doorClose", 0, 0.0f);
            doorOpen = false;
        }
    }
}
