using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Text score;
    [SerializeField] Image gameOver;
    int scoreCount;

    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            Restart();
        }
    }
    public void IncreaseScore(int i)
    {
        scoreCount+=i;
        score.text=scoreCount.ToString();
    }

    public void GameOver()
    {
        gameOver.gameObject.SetActive(true);
        Time.timeScale=0f;
    }

    public void Restart()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
