using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float bottom = 0;
    // Start is called before the first frame update
    public float speed = -10f;
    private GameController gc;
    public static GameObject player;
    private PlayerController pc;
    // Update is called once per frame
    private void Awake()
    {
        player = GameObject.Find("Player");
        gc = Camera.main.GetComponent<GameController>();
        pc = player.GetComponent<PlayerController>();
    }
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime);
        if(transform.position.y < bottom)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.tag == "Player")
        {
            if (!pc.isInvulnerable())
            {
                gc.SetLives(-1);
                pc.Hit();
            }
            Destroy(this.gameObject);
        }
    }
}
