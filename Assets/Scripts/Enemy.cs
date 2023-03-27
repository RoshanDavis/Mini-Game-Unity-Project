using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float lifeTime;
    GameManager gameManager;
    void Start()
    {
        Destroy(gameObject,lifeTime);
        gameManager=GameObject.FindObjectOfType<GameManager>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.CompareTag("Player")){
            gameManager.GameOver();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        gameManager.IncreaseScore(1);
        Destroy(gameObject);
    }
}
