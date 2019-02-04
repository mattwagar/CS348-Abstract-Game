using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform LeftBound;
    public Transform RightBound;
    public Transform TopBound;
    public Transform BottomBound;

    public float Speed = 1;
    


    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
        }


        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 TargetLocation = new Vector3(mouse.x, mouse.y, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, TargetLocation, 0.01f*Speed);

        if (transform.position.x < LeftBound.position.x)
        {
            transform.position = new Vector3(LeftBound.position.x,transform.position.y,transform.position.z);
        }
        if (transform.position.x > RightBound.position.x)
        {
            transform.position = new Vector3(RightBound.position.x,transform.position.y,transform.position.z);
        }
        if (transform.position.y > TopBound.position.y)
        {
            transform.position = new Vector3(transform.position.x,TopBound.position.y,transform.position.z);
        }
        if (transform.position.y < BottomBound.position.y)
        {
            transform.position = new Vector3(transform.position.x,BottomBound.position.y,transform.position.z);
        }
    }
}
