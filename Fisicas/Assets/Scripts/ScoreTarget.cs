using UnityEngine;

public class ScoreTarget : MonoBehaviour
{

    public float score;
    public static float totalScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("+" + score);
        totalScore += score;
        print("Total: " + totalScore);
    }
}
