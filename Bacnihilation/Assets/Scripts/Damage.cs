using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public GameObject damageBox;
    public GameObject gameOverPainel, damagePainel;
    private float timer;
    public GameObject enemy1, enemy2, ally;

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
            Destroy(collision.gameObject);
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
            Destroy(collision.gameObject);
        }



    }

    public void RestartBTN()
    {
        SceneManager.LoadScene(1);
        HeartSistem.life += 4;
        gameOverPainel.SetActive(false);
        Time.timeScale = 1;
        Enemy.point = 0;
    }
    public void BackToMenu()
    {
        gameOverPainel.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
