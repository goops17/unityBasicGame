﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset=new Vector3(0,1,-5);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //displaying player position
        //Debug.Log(player.position);
        //following player movement
        transform.position = player.position + offset;
    }
}
