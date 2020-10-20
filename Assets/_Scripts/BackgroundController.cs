////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: BackgroundController.cs
//FileType: Visual C# Script
//Author: Lucas Coates
//Student Number: 101172500
//Last Modified On: 10/20/2020 11:17 AM
//Copy Rights: Mana Burn
//Description: Class that controls the back ground movement to scroll it then reset it to make 
//             a continuous scroll effect.
///////////////////////////////////////////////////////////////////////////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [Header("Background controls")]
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        Debug.Log("reset");
        transform.position = new Vector3(-horizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(-horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x >= horizontalBoundary)
        {
            _Reset();
        }
    }
}
