using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    Color RGBColor(float r, float g, float b)
    {
        if (r > 255)
            r = 255f;

        if (g > 255)
            g = 255f;

        if (b > 255)
            b = 255f;

        r /= 255f;
        g /= 255f;
        b /= 255f;

        return new Color(r, g, b);
    }

    void OnCollisionEnter2D(Collision2D col) 
    {
        Color Darkblue = RGBColor(38, 70, 83);
        Color Green = RGBColor(42, 157, 143);
        Color Yellow = RGBColor(233, 196, 106);
        Color Orange = RGBColor(42, 157, 143);
        Color oOrange = RGBColor(231, 111, 81);

        Color[] coArray = { Darkblue, Green, Yellow, Orange, oOrange, Color.white };
        int currentCount = col.gameObject.GetComponent<Bounce>().currentCount;
        currentCount++;
        if(currentCount > 5)
        {
            currentCount = 0;
        }

        col.gameObject.GetComponent<Bounce>().currentCount = currentCount;
        col.gameObject.GetComponent<SpriteRenderer>().color = coArray[currentCount];
    }
}
