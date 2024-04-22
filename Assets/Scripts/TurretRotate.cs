using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform turret;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            turret.RotateAround(turret.position, turret.right, -2);
        }
        else if (Input.GetKey(KeyCode.G))
        {
            turret.RotateAround(turret.position, turret.right, 2);
        }
    }
}
