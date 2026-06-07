using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float minSize = 0.75f;
    public float maxSize = 2.5f;
    public float minSpeed = 100f;
    public float maxSpeed = 300f;
    public float maxSpinSpeed = 15f;

    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSize = Random.Range(minSize, maxSize);
        float randomSpeed = Random.Range(minSpeed, maxSpeed) / randomSize;
        float randomTorque = Random.Range(-maxSpinSpeed, maxSpinSpeed);
        Vector2 randomDirection = Random.insideUnitCircle;

        transform.localScale = new Vector3(randomSize, randomSize, 1);

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(randomDirection * randomSpeed);
        rb.AddTorque(randomTorque);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
