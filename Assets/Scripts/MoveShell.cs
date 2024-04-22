using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShell : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moving = Time.deltaTime * speed;
        this.transform.Translate(0, moving * 0.5f, moving);
    }
}
