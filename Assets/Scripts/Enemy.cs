using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float secondsBetweenProjectile;
    public GameObject EnemyProj;
    public float speed = 3f;
    public float leftEdge = -20f, rightEdge = 20f;
    public float chanceToChangeDirection = 0.001f;
    public int enemyNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        if (enemyNumber == 1)
        {
            secondsBetweenProjectile = 1;
        }
        else if (enemyNumber == 2)
        {
            secondsBetweenProjectile = 0.5f;
            speed = 4f;
        }
        Invoke("FireProjectile", secondsBetweenProjectile);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        
        transform.position = pos;
        if (enemyNumber == 2)
        {
            transform.Rotate(new Vector3(0, 0, 30f) * Time.deltaTime);
        }
        if (transform.position.x > rightEdge)
        {
            speed = -Mathf.Abs(speed); 
        }
        else if(transform.position.x < leftEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if(Random.value < chanceToChangeDirection)
        {
            speed *= -1;
        }

    }

    void FireProjectile()
    {
        Vector3 pos;
        GameObject projectile = Instantiate<GameObject>(EnemyProj);
        pos = transform.position;
        
        pos.y -= 0.5f; 
        projectile.transform.position = pos;
        
        Invoke("FireProjectile", secondsBetweenProjectile);
    }
}
