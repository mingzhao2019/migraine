using UnityEngine;

public class blurchange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float scrollSpeed = 0.1f;
    Renderer rend;

    float materialVisibility = 0.01f;
    Material mat;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
//
        //if (Time.time > 30 && Time.time < 50)
       // {
            mat = GetComponent<Renderer>().sharedMaterial;
            Color color = mat.color;
            //color.a = (Mathf.Sin(Time.time * 0.3f) + 1) * 0.35f;
            color.a = Mathf.Min(color.a + 0.1f * Time.deltaTime, 1.0f);
            mat.color = color;
        //}
    }
}
