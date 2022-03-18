using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_parametric_design : MonoBehaviour
{
    public Vector3 shell;
    public GameObject shellObjCopy;

    public void ParamChange()
    {
        shell = shellObjCopy.transform.localScale;
        shell.x = 1.5f;
        shellObjCopy.transform.localScale = shell;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
