using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _scoreDisplay;

    private void Awake()
    {
        _player.ScoreChanged += OnScoreChanged;
    }

    private void OnDestroy()
    {
        _player.ScoreChanged -= OnScoreChanged;
    }
    
    private void OnScoreChanged(int newScore)
    {
        _scoreDisplay.text = newScore.ToString();
    }
}