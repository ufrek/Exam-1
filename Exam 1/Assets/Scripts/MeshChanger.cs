using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshChanger : GazeOverEvent
{
    [SerializeField]
    GameObject apple;
    [SerializeField]
    GameObject coffee;
    bool isCoffee = true;
    public override void Hovering()
    {
        base.Hovering();
    }

    public override void NotHovering()
    {
        base.NotHovering();
    }

    public override void OnClick()
    {
        base.OnClick();
        if (isCoffee)
        {
            coffee.gameObject.GetComponent<MeshRenderer>().enabled = false;
            apple.gameObject.GetComponent<MeshRenderer>().enabled = true;
            isCoffee = false;
        }
        else 
        {
            coffee.gameObject.GetComponent<MeshRenderer>().enabled = true;
            apple.gameObject.GetComponent<MeshRenderer>().enabled = false;
            isCoffee = true;
        }
            
    }

}
