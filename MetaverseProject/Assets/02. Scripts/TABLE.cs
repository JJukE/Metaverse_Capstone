using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TABLE : MonoBehaviour

{
    public int x, y, z;
    new Vector3 scale = Vector3.zero;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("6"))
        {
            x = x + 1;
        }
        if (Input.GetKeyDown("7"))
        {
            y = y + 1;
        }
        if (Input.GetKeyDown("8"))
        {
            z = z + 1;
        }
        if (Input.GetKey("9"))
        {
            transform.localPosition = new Vector3(x, y, z);
            transform.localScale = new Vector3(100 + x, 100 + y, 100 + z);

        }
        if (Input.GetKey("0"))
        {
            transform.localScale = new Vector3(100, 100, 100);
            transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}