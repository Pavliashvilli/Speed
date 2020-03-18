using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFloat : MonoBehaviour {
   public float speed , tilt;
   public Vector3 target = new Vector3 (0, 0.5f ,0);
    

    void Update()
    {
        transform.position = Vector3.MoveTowards (transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target.y != -1f)
        target.y = -1f;
        else if (transform.position == target && target.y == -1f)
        target.y = 0.5f;
        transform.Rotate (Vector3.forward * Time.deltaTime * tilt);
    }
}
