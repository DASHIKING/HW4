using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int score;
    public AudioSource audioSource;
    public AudioClip scoreSound;

    void Awake()
    {
        Instance = this;
    }

    void OnEnable()
    {
        Bird.OnScore += AddScore;
    }

    void OnDisable()
    {
        Bird.OnScore -= AddScore;
    }

    void AddScore()
    {
        score++;
        audioSource.PlayOneShot(scoreSound);
    }
}
