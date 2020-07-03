﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Health_sys enemy;
    
    void Start()
    {
        enemy = gameObject.AddComponent<Health_sys>();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        EnemyHead head = collision.collider.GetComponent<EnemyHead>();
        Chest chest = collision.collider.GetComponent<Chest>();
        Right_hand right_Hand = collision.collider.GetComponent<Right_hand>();
        Left_hand left_Hand = collision.collider.GetComponent<Left_hand>();
        Right_leg right_Leg = collision.collider.GetComponent<Right_leg>();
        Left_leg left_Leg = collision.collider.GetComponent<Left_leg>();

        if(head)
        {
            head.OnHit(50);
        }
        if(chest)
        {
            chest.OnHit(30);
        }
        if(right_Hand)
        {
            right_Hand.OnHit(15);
        }
        if (left_Hand)
        {
            left_Hand.OnHit(15);
        }
        if (right_Leg)
        {
            right_Leg.OnHit(15);
        }
        if (left_Leg)
        {
            left_Leg.OnHit(15);
        }
        Destroy(gameObject);

    }
}
