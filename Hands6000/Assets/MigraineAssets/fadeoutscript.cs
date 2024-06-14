using UnityEngine;

public class fadeoutscript : MonoBehaviour
{
    CanvasRenderer rend;
    float materialVisibility = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<CanvasRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //TODO 100 at start, fadein to 2 seconds, fadeout at 3minutes same as fadeoutscript
        if (Time.time < 10 && materialVisibility > 0)
        {
            materialVisibility = materialVisibility - 0.5f * Time.deltaTime;
            // update material visibility
            rend.SetColor(new Color(0f, 0f, 0f, materialVisibility));
        }
        if (Time.time > 10 && Time.time < 160)
        {
            rend.SetColor(new Color(0f, 0f, 0f, 0f));
        }
        if (Time.time > 160)
        {
            materialVisibility = materialVisibility + 0.5f * Time.deltaTime;
            // update material visibility
            rend.SetColor(new Color(0f, 0f, 0f, materialVisibility));
        }
    }
}
