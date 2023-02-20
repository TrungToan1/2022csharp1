using UnityEngine;
using System.Collections;

public class StartAnimation : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
        }
    }
}