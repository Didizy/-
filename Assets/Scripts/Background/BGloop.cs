using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class BGloop : MonoBehaviour
{
    private Vector2 offset = Vector2.zero;
    private Material material;
    void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = material.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        offset.x += Generally.speed * Time.deltaTime;
        material.SetTextureOffset("_MainTex", offset);
    }
}
