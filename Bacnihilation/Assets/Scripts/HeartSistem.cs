using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class HeartSistem : MonoBehaviour
{
    public static HeartSistem Instance;
    public static int life;    //vida atual
    public int maxLife;       //vida máxima

    public Image[] heart;
    public Sprite full;
    public Sprite empty;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        life = maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        HealthLogic();
    }
    void HealthLogic()
    {
        if (life > maxLife)
        {
            life = maxLife;
        }
        for (int i = 0; i < heart.Length; i++)
        {
            if(i < life)
            {
                heart[i].sprite = full;
            }
            else
            {
                heart[i].sprite = empty;
            }

            if (i < maxLife)
            {
                heart[i].enabled = true;
            }
            else
            {
                heart[i].enabled = false;
            }
        }
    }
}
//https://www.youtube.com/watch?v=6SAbQfz3QRI
//
