using UnityEngine;

public class fadeoutscript : MonoBehaviour
{
    CanvasRenderer rend;
    float materialVisibility = 1f;
    public AudioSource narration;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<CanvasRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //TODO 100 at start, fadein to 2 seconds, fadeout at 3minutes same as fadeoutscript
        if (narration.time < 5 && materialVisibility > 0)
        {
            materialVisibility = materialVisibility - 0.5f * Time.deltaTime;
            // update material visibility
            rend.SetColor(new Color(0f, 0f, 0f, materialVisibility));
        }
        if (narration.time > 5 && narration.time < 180)
        {
            rend.SetColor(new Color(0f, 0f, 0f, 0f));
        }
        if (narration.time > 180)
        {
            materialVisibility = Mathf.Min(materialVisibility + 0.2f * Time.deltaTime, 1.0f);
            // update material visibility
            rend.SetColor(new Color(0f, 0f, 0f, materialVisibility));
        }
    }
}
