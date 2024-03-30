using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public GameObject damageBox;
    public GameObject gameOverPainel, damagePainel;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        //timer += Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (HeartSistem.life <= 0)
        {
            gameOverPainel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.GetComponent<GameObject>());
            HeartSistem.life -= 1;

            /*damagePainel.SetActive(true);
            
            if (timer >= 0.2f)
            {
                damagePainel.SetActive(false);
                timer = 0;
            }*/
        }
        if (collision.CompareTag("Ally"))
        {
            Destroy(collision.GetComponent<GameObject>());
        }



    }

    public void RestartBTN()
    {
        SceneManager.LoadScene(1);
        gameOverPainel.SetActive(false);
        Time.timeScale = 1;
    }
    public void BackToMenu()
    {
        gameOverPainel.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
