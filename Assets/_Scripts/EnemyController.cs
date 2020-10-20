////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: EnemyController.cs
//FileType: Visual C# Script
//Author: Lucas Coates
//Student Number: 101172500
//Last Modified On: 10/20/2020 11:18 AM
//Copy Rights: Mana Burn
//Description: Class that controls the movement of the enemies making them go up and down
//             then when it reaches the top/ bottom of the screen it reverses the direction         
///////////////////////////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Enemy movement")]
    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check up boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check bottom boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
