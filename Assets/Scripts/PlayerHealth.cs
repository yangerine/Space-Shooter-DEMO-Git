using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    protected override void die()
    {
        base.die();
        Debug.Log("The player was hit!");
    }
}
