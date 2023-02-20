using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchCube : MonoBehaviour
{
    Rigidbody rig;
    float magnitude = 5;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            rig = GetComponent<Rigidbody>();
            rig.AddForce(Vector3.up * magnitude, ForceMode.Impulse);
        }
    }
}
