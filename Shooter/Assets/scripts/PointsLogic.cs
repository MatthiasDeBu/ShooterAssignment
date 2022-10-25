using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsLogic : MonoBehaviour
{
    public static int pointsPicked;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "target")
        {
            pointsPicked++;
        }
    }
}
