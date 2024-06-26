        using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public GameObject audioGameplay;
    public GameObject damageBox;
    public GameObject gameOverPainel, damagePainel;
    public GameObject enemy1, enemy2, ally;

    void Update()
    {
        if (HeartSistem.life <= 0)
        {
            audioGameplay.GetComponent<AudioSource>().enabled = false;
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
