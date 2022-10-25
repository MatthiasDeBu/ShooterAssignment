using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public float sideSpeed = 1f;
    public float spinSpeed = 50f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);

        transform.Translate(Vector3.right * Mathf.Sin(Time.timeSinceLevelLoad) * sideSpeed * Time.deltaTime);
    }
}
