using UnityEngine;

public class Scroll : MonoBehaviour
{
    private float scrollSpeed = 0.05f;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        Vector2 offset = new Vector2(Time.time * scrollSpeed, 0);
        rend.material.mainTextureOffset = offset;
    }
}
