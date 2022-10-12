using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _boards = new GameObject[2];
    [SerializeField]
    private GameObject[] _playerShips = new GameObject[7];
    [SerializeField]
    private GameObject[] _enemyShips = new GameObject[7];
    [SerializeField]
    private Scene[] _scenes;
    [SerializeField]
    private int _boardDimensionX;
    [SerializeField]
    private int _boardDimensionY;

    // Start is called before the first frame update
    void Start()
    {
        _boards[0] = CreateBoardInHierarchy("EnemyBoard");

        EnemyBoard enemyBoard = _boards[0].GetComponent<EnemyBoard>();
        enemyBoard.GenerateBoard(_boardDimensionX, _boardDimensionY);
    }

    private GameObject CreateBoardInHierarchy(string boardName)
    {
        GameObject board = new GameObject(boardName);

        if (boardName.Equals("EnemyBoard"))
        {
            board.AddComponent<EnemyBoard>();
        }
        else
        {
            board.AddComponent<PlayerBoard>();
        }

        board.tag = "Board";

        return board;
    }
}
