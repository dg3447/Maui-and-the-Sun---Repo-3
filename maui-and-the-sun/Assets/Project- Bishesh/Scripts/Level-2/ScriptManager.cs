﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptManager : MonoBehaviour
{
    public GameObject openingInfo;




    public void destoryObject()
    {
        Destroy(openingInfo.gameObject);
    }
}
