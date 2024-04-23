using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    public TMP_Text pontuation;

    private void Awake()
    {
        instance = this;
    }
}
