using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public GameObject damageBox;
    public GameObject gameOverPainel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HeartSistem.life <= 0)
        {
            gameOverPainel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            gameOverPainel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.GetComponent<Enemy>());
            HeartSistem.life -= 1;
        }
    }

    public void RestartBTN()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
