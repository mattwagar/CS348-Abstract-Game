using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public int rotateX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotator();
        GrowShrink();

    }

    private void GrowShrink()
    {
        
    }

    private void Rotator()
    {
        transform.Rotate(Vector3.right * rotateX * Time.deltaTime);
    }
}
