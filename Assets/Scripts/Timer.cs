using UnityEngine;

public class Timer : MonoBehaviour {
    float duration = 0, elapsed = 0;
    bool running = false, started = false;

    void Update() {
        if (running) elapsed += Time.deltaTime;

        if (elapsed >= duration) {
            running = false;
            elapsed = 0;
        }
    }

    public void Run() {
        if (duration > 0) {
            running = true;
            started = true;
            elapsed = 0;
        }
    }

    public float Duration { set { if (value > 0) duration = value; } }
    public bool Finished { get { return started && !running; } }
    public bool Running { get { return running; } }
}