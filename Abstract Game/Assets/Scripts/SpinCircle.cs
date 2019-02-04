using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCircle : MonoBehaviour
{
    public Transform pivot;
    public Transform[] circleParts;
    [Range(0,100f)]public float speed;
    float[] rotations;
    // Start is called before the first frame update
    void Start()
    {
        rotations = new float[circleParts.Length];
        for(int i = 0; i < circleParts.Length; i++)
        {
            rotations[i] = Random.Range(0,359);
            circleParts[i].RotateAround(pivot.position, Vector3.forward, rotations[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < circleParts.Length; i++)
        {
            circleParts[i].RotateAround(pivot.position, Vector3.forward, ((float)i+1)/(float)circleParts.Length * speed);
        }
    }
}
