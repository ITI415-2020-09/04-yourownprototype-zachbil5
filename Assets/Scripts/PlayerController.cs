using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition; // 1
                                                  // The Camera's z position sets the how far to push the mouse into 3D
        mousePos2D.z = -Camera.main.transform.position.z; // 2
                                                          // Convert the point from 2D screen space into 3D game world space
        Vector3 mousePos3D =
        Camera.main.ScreenToWorldPoint(mousePos2D); // 3
                                                    // Move the x position of this Basket to the x position of the Mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        pos.y = mousePos3D.y;
        pos.x = Mathf.Clamp(pos.x,-19, 19);
        pos.y = Mathf.Clamp(pos.y, 1, 19);
        this.transform.position = Vector3.Lerp(transform.position,pos,0.05f);
    }

    private void OnMouseDown()
    {
       GameObject projectile = Instantiate(ProjectilePrefab) as GameObject;
        projectile.transform.position = transform.position;
    }
}
