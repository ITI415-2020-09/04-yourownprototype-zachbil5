using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy1;
    private GameController gc;
    private int level = 0;
    // Start is called before the first frame update
    void Start()
    {
        gc = Camera.main.GetComponent<GameController>();
        level = gc.levelNumber;
        spawnEnemy();
    }

    // Update is called once per frame

    public void spawnEnemy()
    {
        
        if (level == 1)
        {
            GameObject enemyObj = Instantiate(enemy1) as GameObject;
            enemyObj.transform.position = transform.position;
        }
        //if(level == 2){}
        //if(level == 3){}
        
    }
}
