using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraTransform : MonoBehaviour
{
    Vector3 target = new Vector3(0.5f, 1.75f, -1f);
    Vector3 targetangle = new Vector3(0, 0, 0);

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, 0, 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-5 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, 0, -5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(5 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.R))
        {
            this.transform.Translate(0, 5 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.F))
        {
            this.transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Rotate(-60 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0, -60 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Rotate(60 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0, 60 * Time.deltaTime, 0);
        }
        if (Input.GetKey(","))
        {
            this.transform.Rotate(0, 0, 60 * Time.deltaTime);
        }
        if (Input.GetKey("."))
        {
            this.transform.Rotate(0, 0, -60 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.O))
        {
            transform.position = Vector3.MoveTowards(transform.position, target, 10f);
            transform.localEulerAngles = Vector3.RotateTowards(transform.localEulerAngles, targetangle, 1000f, 1000f);

        }
    }
}
