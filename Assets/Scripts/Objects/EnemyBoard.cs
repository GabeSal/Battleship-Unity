using System;
using UnityEngine;

public class EnemyBoard : Board
{
    /// <summary>
    /// Method will be responsible for choosing a random cell on the enemy board as an
    /// origin point to "place" a ship.
    /// </summary>
    public void ChooseRandomCellForShip()
    {
        int randomFirstIndex = GenerateRandomNumber();
        int randomSecondIndex = GenerateRandomNumber();

        Debug.Log(string.Format("Random cell selected: Cell {0}{1}", randomFirstIndex, randomSecondIndex));

        ChooseCorrespondingCell(randomFirstIndex, randomSecondIndex);
    }

    /// <summary>
    /// Method that searches for an appropriate adjacent cell depending on the placed ships orientation.
    /// </summary>
    /// <param name="firstOriginIndex">Int value from the ChooseRandomCellForShip method</param>
    /// <param name="secondOriginIndex">Int value from the ChooseRandomCellForShip method</param>
    private void ChooseCorrespondingCell(int firstOriginIndex, int secondOriginIndex)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Utility method that generates a random number using Unity's Random.Range function
    /// </summary>
    /// <returns>Int value that will act as the appropriate index for the boards 2D _cell array</returns>
    private int GenerateRandomNumber()
    {
        return (int)Math.Round(UnityEngine.Random.Range(0f, 9f));
    }
}
