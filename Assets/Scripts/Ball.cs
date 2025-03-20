
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector3 position = transform.position;
        position.x = 2;
        transform.position = position;
        transform.localScale *= 2;
        
        float mag = Random.Range(3, 5);
        float dir = Random.Range(0, 2 * Mathf.PI);
        Vector2 force = new Vector2(Mathf.Cos(dir), Mathf.Sin(dir)) * mag;
        Debug.Log($"Magnitude: {mag}, Direction: {dir*180/Mathf.PI}*");
        rb.AddForce(force, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
