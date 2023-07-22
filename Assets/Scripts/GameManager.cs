using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    public Player[] players;
    public GameBoard gameBoard;

    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        InitializePlayers();
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        gameBoard.Initialize();
    }

    private void InitializePlayers()
    {
        var playerCount = 2;
        players = new Player[playerCount];
        for (var i = 0; i < players.Length; i++)
        {
            players[i] = new Player();
        }
    }
}
