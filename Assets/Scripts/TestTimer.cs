using UnityEngine;

public class TestTimer : MonoBehaviour {
    Timer timer;
    float init, start;

    void Start() {
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 5f;
        timer.Run();
        start = Time.time;
        init = Time.time;
    }

    void Update()
    {
        if (timer.Finished) {
            float elapsed = Time.time - start;
            Debug.Log($"Timer ran for {elapsed} seconds.\nTotal time elapsed: {Time.time - init}");
            timer.Run();
            start = Time.time;
        }
    }
}