using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameObject bacterias;
    public Text scoreText;

    private void OnMouseDown()
    {
        Debug.Log("I morreu");
        Destroy(gameObject);
    }
}
