using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
using System.Windows.Input;

public class Moving : MonoBehaviour
{
    private float position = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Generally.ObjectVecor.y += Generally.ObjectSpeed;
            transform.localPosition = Generally.ObjectVecor;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Generally.ObjectVecor.y -= Generally.ObjectSpeed;
            transform.localPosition = Generally.ObjectVecor;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Generally.speed -= Generally.deltaSpeed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Generally.speed += Generally.deltaSpeed;
        }
    }
}

