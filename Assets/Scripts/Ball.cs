
using UnityEngine;

public class Ball : MonoBehaviour
{
    int bounces;
    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        bounces = 0;
        
        rb = GetComponent<Rigidbody2D>();
        transform.localScale *= 2;
        float mag = Random.Range(3f, 10f);
        float dir = Random.Range(0, 2 * Mathf.PI);
        Vector2 force = new Vector2(Mathf.Cos(dir), Mathf.Sin(dir)) * mag;
        Debug.Log($"Magnitude: {mag}, Direction: {dir*180/Mathf.PI}*");
        rb.AddForce(force, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update() {
        if (bounces > 20) {
            Destroy(gameObject);
            Debug.Log("Bang!");
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        bounces++;
        Debug.Log($"Bounces: {bounces}");
    }
}
