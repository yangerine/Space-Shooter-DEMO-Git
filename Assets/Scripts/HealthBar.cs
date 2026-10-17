using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public RectTransform mask;
    public Health health;
    private float originalWidth;

    // Start is called before the first frame update
    void Start()
    {
        //nhan kich thuoc ban dau cua mask
        //them method updateHealthvalue() vao event system onHealChange

        originalWidth = mask.sizeDelta.x;
        updateHealthValue();
        health.onHealthChange += updateHealthValue;
    }

    public void updateHealthValue()
    {
        //tinh ty le mau: lay luong mau hien tai / luong mau tong
        //nhan ty le mau voi kich thuoc mask de the hien luong mau tren game world

        float scale = (float)health.health_point / health.default_health_point;
        mask.sizeDelta = new Vector2(scale * originalWidth, mask.sizeDelta.y);
    }

  
}
