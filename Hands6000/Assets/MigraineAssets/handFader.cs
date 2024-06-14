using UnityEngine;

public class handFader : MonoBehaviour
{
    Renderer rend;
    float targetX = -0.12f;
    float targetY = 0f;
    float targetZ = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(rend.materials[1].GetVector("_FadeCenter"));
        Vector3 fadecenter = rend.materials[1].GetVector("_FadeCenter");
        fadecenter.z = -0.1f;

        // rend.materials[1].SetVector("_FadeCenter", fadecenter);

        if (Time.time > 39)
        {
            rend.materials[1].SetVector("_FadeCenter", new Vector3(targetX,targetY,targetZ) );
        }
    }

    // fade center -0.12, 0, 0.1
}
