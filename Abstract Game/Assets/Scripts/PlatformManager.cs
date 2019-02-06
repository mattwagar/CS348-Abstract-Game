// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlatformManager : MonoBehaviour
// {
//     public float speed;
//     public GameObject[]  shapePrefabs;
//     // private BoxCollider2D boxCollider;

//     private BoxCollider2D[] Boxes;
//     private float[] Scales;

//     // Start is called before the first frame update
//     void Start()
//     {
//         Boxes = new BoxCollider2D[shapePrefabs.Length];
//         Scales = new float[shapePrefabs.Length];
//         float length = 0f;
//         for(int i = 0; i < shapePrefabs.Length; i++)
//         {
//             GameObject platform = Instantiate(shapePrefabs[i], Vector3.zero, Quaternion.identity);
//             Boxes[i] = platform.GetComponent<BoxCollider2D>();
//             Scales[i] = Random.Range(1f, 5f);
//             Boxes[i].transform.localScale = new Vector3(Scales[i], transform.localScale.y, transform.localScale.z);
//             length += Scales[i] * 0.8f; 
//             Boxes[i].transform.position = startPoint.position;
//         }
//     }

//     // Update is called once per frame
//     void Update()
//     {

//         for(int i = 0; i < Boxes.Length; i++)
//         {
//             Boxes[i].transform.Translate(-speed, 0, 0);
//             if(Boxes[i].Distance(outOfBoundsCollider).isOverlapped)
//             {
//                 Debug.Log("wowza");
//                 Boxes[i].transform.position = new Vector3(startPoint.position.x, Boxes[i].transform.position.y, Boxes[i].transform.position.z);
//                 Scales[i] = Random.Range(7.5f, 8.5f);
//                 Boxes[i].transform.localScale = new Vector3(Scales[i], transform.localScale.y, transform.localScale.z);
//             }

//         }
        

//     }

// }
