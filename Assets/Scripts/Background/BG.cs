using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class DEMO
{
}
public class BG : MonoBehaviour
{
    void Start()
    {

        switch (gameObject.name){
            case "Background":
                transform.localScale = new Vector3(Generally.width, Generally.heigth, 0);
                break;
            case "Ground":
                transform.localScale = new Vector3(Generally.width + 3f,5,0);
                break;
        }
    }
}
