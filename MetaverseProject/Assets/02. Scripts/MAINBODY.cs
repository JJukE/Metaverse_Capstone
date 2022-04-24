using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAINBODY : MonoBehaviour

{
    public int x, y, z;
    new Vector3 scale = Vector3.zero;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j"))
        {
            x = x + 1;
        }
        if (Input.GetKeyDown("k"))
        {
            y = y + 1;
        }
        if (Input.GetKeyDown("l"))
        {
            z = z + 1;
        }
        if (Input.GetKey("u"))
        {
            transform.localPosition = new Vector3(2*x, y, 3*z);
            transform.localScale = new Vector3(x, y, z);

        }
        if (Input.GetKey("i"))
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}