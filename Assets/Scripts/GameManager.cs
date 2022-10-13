using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Serialized Fields
    [SerializeField]
    private Scene[] _scenes;
    #endregion

    #region 'Manager' Objects
    public AudioManager audioManager;
    public BoardManager boardManager;
    public ShipManager shipManager;
    #endregion

    #region Public Data Members
    public bool PlayerTurn = true;
    #endregion

    #region Private Data Members
    private static GameManager _instance;
    #endregion

    #region Constructor
    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("ERROR: No GameManager exists in the scene!");
            }

            return _instance;
        }
    }
    #endregion

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
    }
}
