﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launch : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        gameObject.AddComponent<PanelMgr>();
        PanelMgr.instance.OpenPanel<MenuePl>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
