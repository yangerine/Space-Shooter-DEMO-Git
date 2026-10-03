using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showLog : MonoBehaviour
{
   void Start()
    {
        Debug.Log("Hello World!");
    }

    void Update()
    {
        Debug.Log("Update Called!" + Time.frameCount);
    }

}
