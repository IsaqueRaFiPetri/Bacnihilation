using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Enemy : MonoBehaviour
{
    public GameObject bacterias;
    public int remainClicks;
    public static int point;
    public string pontuation;

    private void OnMouseDown()
    {
        remainClicks -= 1;
        if (remainClicks <= 0)
        {
            point += 1;
            pontuation = point.ToString();
            GameController.instance.pontuation.text = pontuation;
            Destroy(gameObject);
        }
    }
    
}
//Richard esteve aqui