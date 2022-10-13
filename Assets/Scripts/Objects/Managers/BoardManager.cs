using System;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    #region Serialized Fields
    [SerializeField]
    private GameObject[] _boards = new GameObject[2];
    [SerializeField]
    private int _boardDimensionX;
    [SerializeField]
    private int _boardDimensionY;
    #endregion

    #region Private Data Members
    private EnemyBoard _enemyBoard;
    private PlayerBoard _playerBoard;
    private ShipManager _shipManager;
    #endregion

    // Start is called before the first frame update
    private void Start()
    {
        _shipManager = GameManager.Instance.shipManager.GetComponent<ShipManager>();

        _boards[0] = CreateBoardInHierarchy("EnemyBoard");
        // _boards[1] = CreateBoardInHierarchy("PlayerBoard");

        _enemyBoard = _boards[0].GetComponent<EnemyBoard>();
        // _playerBoard = _boards[1].GetComponent<PlayerBoard>();

        GenerateBoards();
    }

    /// <summary>
    /// Public method that is called by the BoardManager to begin board generation 
    /// for the player and CPU
    /// </summary>
    /// <param name="dimX">Int value that represents the number rows in the board</param>
    /// <param name="dimY">Int value that represents the number columns in the board</param>
    private void GenerateBoards()
    {
        if (_boards.Length > 0)
        {
            // Create the enemy board first...
            _enemyBoard.SetDimensionsCellArray(_boardDimensionX, _boardDimensionY);
            PopulateBoard(_enemyBoard);
            PlaceEnemyShips();

            // followed by the player board
            /*PlayerBoard playerBoard = _boards[1].GetComponent<PlayerBoard>();
            playerBoard.SetDimensionsCellArray(_boardDimensionX, _boardDimensionY);
            PopulateBoard(playerBoard);
            */
        }
        else
        {
            Debug.LogError("There are no boards to generate! Please check the " +
                "CreateBoardInHierarchy method for potential errors.");
        }
    }

    /// <summary>
    /// Method that will start the randomized placement of ships for the enemy board.
    /// Will utilize the GameManagers ShipManager object to be responsible for the
    /// physical placement of the ships onto the correct cells.
    /// </summary>
    private void PlaceEnemyShips()
    {
        _enemyBoard.ChooseRandomCellForShip();
    }

    /// <summary>
    /// Method that loads the Cell prefab in the Resources/Prefabs folder and instantiates a cell 
    /// at a certain position, then stores a reference of the cellInstance in the boards 2D _cells array
    /// </summary>
    private void PopulateBoard(Board board)
    {
        GameObject cellInstance = Resources.Load("Prefabs/Cell", typeof(GameObject)) as GameObject;

        for (int i = 0; i < _boardDimensionX; i++)
        {
            for (int j = 0; j < _boardDimensionX; j++)
            {
                GameObject newCell = Instantiate(cellInstance, board.SetCellPosition(i, j), Quaternion.identity, board.transform);
                newCell.name = string.Format("Cell {0}{1}", i, j);
                board.AllocateCells(i, j, newCell);
            }
        }
    }

    /// <summary>
    /// Creates a new game object that will act as the Battleship board to hold cells and ship pieces
    /// </summary>
    /// <param name="boardName">String value that will name the board object</param>
    /// <returns></returns>
    private GameObject CreateBoardInHierarchy(string boardName)
    {
        GameObject board = new GameObject(boardName);

        board.tag = "Board";

        // Distinguish between an enemy board and player/user board
        if (boardName.Equals("EnemyBoard"))
        {
            board.AddComponent<EnemyBoard>();
        }
        else
        {
            board.AddComponent<PlayerBoard>();
        }

        // Set the board as a child to the BoardManager object
        board.gameObject.transform.SetParent(this.transform);

        return board;
    }
}
