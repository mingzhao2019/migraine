using UnityEngine;

public class movetexture : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float scrollSpeed = 0.1f;
    Renderer rend;

    float materialVisibility = 0.01f;

    void Start()
    {
        rend = GetComponent<Renderer>();
        // Create a new RGBA color using the Color constructor and store it in a variable
        Color customColor = new Color(0.9f, 0.9f, 0.9f, materialVisibility);

        // Call SetColor using the shader property name "_Color" and setting the color to the custom color you created
        rend.material.SetColor("_Color", customColor);
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));

        if (Time.time > 30 && Time.time < 160 && materialVisibility < 0.5f)
        {
            materialVisibility = materialVisibility + 0.001f * Time.deltaTime;
            rend.material.SetColor("_Color", new Color(0.9f, 0.9f, 0.9f, materialVisibility));
            
        }

        else if (Time.time > 160)
        {
            materialVisibility = materialVisibility - 0.5f * Time.deltaTime;
            if (materialVisibility <0)
            {
                materialVisibility = 0;
            }
            // update material visibility
            rend.material.SetColor("_Color", new Color(0.9f, 0.9f, 0.9f, materialVisibility));
            
        }
    }
}
