using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turntable : MonoBehaviour
{
    public Transform target;
    public float speed = 0.1f;
    
    void Update()
    {
        target.Rotate(new Vector3(.0f,this.speed,.0f));
    }
}
