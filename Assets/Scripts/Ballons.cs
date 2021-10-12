using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballons : MonoBehaviour
{
    public float speed = 0.2f;
    public int score;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        Debug.Log(Mathf.PingPong(0, 10));
    }
}
