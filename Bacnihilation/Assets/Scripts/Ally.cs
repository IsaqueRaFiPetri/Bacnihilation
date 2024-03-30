using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Ally : MonoBehaviour
{
    public GameObject atom;
    public int remainClicks;
    
    private void OnMouseDown()
    {
        remainClicks -= 1;
        if (remainClicks <= 0)
        {
            Destroy(gameObject);
            HeartSistem.life -= 1;
        }
    }
}