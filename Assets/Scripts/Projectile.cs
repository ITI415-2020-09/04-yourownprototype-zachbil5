using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    private static float top = 20;
    public float speed = 10f;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime);
       if(transform.position.y > top)
        {
            Destroy(this.gameObject);
        } 
    }
}
