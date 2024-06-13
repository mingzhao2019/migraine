using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disturbance : MonoBehaviour
{
    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 10)
        {
            mat = GetComponent<Renderer>().sharedMaterial;
            Color color = mat.color;
            color.a = (Mathf.Sin(Time.time * 0.3f) + 1) * 0.35f;
            mat.color = color;
        }
    }
}
