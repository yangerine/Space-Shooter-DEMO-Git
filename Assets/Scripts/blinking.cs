using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer; //khai bao

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); //gan gia tri
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.enabled = !spriteRenderer.enabled; //blinking
    }
}
