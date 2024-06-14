using UnityEngine;

public class returntostart : MonoBehaviour
{
    Vector3 startingpos;
    Quaternion startingrot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startingpos = transform.position;
        startingrot = transform.rotation;
    }

    public void Return()
    {
        transform.position = startingpos;
        transform.rotation = startingrot;
    }
}
