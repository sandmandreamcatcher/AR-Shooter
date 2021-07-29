using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private int _score = 0;

    public event UnityAction<int> ScoreChanged;

    public void AddScore()
    {
        _score++;
        ScoreChanged?.Invoke(_score);
    }
}