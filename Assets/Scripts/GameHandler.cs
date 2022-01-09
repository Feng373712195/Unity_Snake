using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;

public class GameHandler : MonoBehaviour
{
    private static GameHandler instance;

    private static int score;

    [SerializeField] private Snake snake;
    private LevelGrid levelGrid;

    private void Awake()
    {
        instance = this;
        InitializeStatic();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GameHandler.Start");

        levelGrid = new LevelGrid(20, 20);

        snake.Setup(levelGrid);
        levelGrid.Setup(snake);
    }

    private static void InitializeStatic()
    {
        score = 0;
    }

    public static int GetScore()
    {
        return score;
    }
    public static void AddScore()
    {
        score += 100;
    }

    public static void SnakeDied()
    {
        GameOverWindow.ShowStatic();
    }

}
