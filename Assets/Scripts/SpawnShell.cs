using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShell: MonoBehaviour
{
    // Start is called before the first frame update
    public Transform gunObj;
    public GameObject shell;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shell, gunObj);
        }
    }
}
