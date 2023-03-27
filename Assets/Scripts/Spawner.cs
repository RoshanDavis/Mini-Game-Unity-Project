using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float minX,maxX,maxSpawnTime,difficulty,difficultyLimit;
    float currentSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        currentSpawnTime=maxSpawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentSpawnTime<=0){
            SpawnEnemy();
            currentSpawnTime=maxSpawnTime;
            if(maxSpawnTime>=difficultyLimit)
            {
                maxSpawnTime-=difficulty;
            }  
        }
        else{
            currentSpawnTime-=Time.deltaTime;
        }
    }

    void SpawnEnemy()
    {
        Vector2 loc = new Vector2(Random.Range(minX,maxX),transform.position.y);
        Instantiate(enemy,loc,Quaternion.identity);
    }
}
