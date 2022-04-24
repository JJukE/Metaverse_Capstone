using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHUCK : MonoBehaviour

{
    public int x, y, z;
    new Vector3 scale = Vector3.zero;

    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            x = x + 1;
        }
        if (Input.GetKeyDown("x"))
        {
            y = y + 1;
        }
        if (Input.GetKeyDown("c"))
        {
            z = z + 1;
        }
        if (Input.GetKey("v"))
        {
            transform.localPosition = new Vector3(x-100, y-100, z-100);
            transform.localScale = new Vector3(100+x, 100+y, 100+z);

        }
        if (Input.GetKey("b"))
        {
            transform.localScale = new Vector3(100, 100, 100);
            transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}