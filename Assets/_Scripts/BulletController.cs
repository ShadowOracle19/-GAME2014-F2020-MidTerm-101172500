////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: BulletController.cs
//FileType: Visual C# Script
//Author: Lucas Coates
//Student Number: 101172500
//Last Modified On: 10/20/2020 11:20 AM
//Copy Rights: Mana Burn
//Description: Class that controls the bullets so they go to the right and when they reach the end of the screen
//             it will return the bullet back to the player so they can fire continuously
///////////////////////////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    [Header("Bullet Controls")]
    public float verticalSpeed;
    public float verticalBoundary;
    public BulletManager bulletManager;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position -= new Vector3(verticalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.x >= verticalBoundary)
        {
            Debug.Log("return");
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
