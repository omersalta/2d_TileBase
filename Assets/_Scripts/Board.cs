using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int row;
    public int column;
    public GameObject _tilePrefab;
    private List<GameObject> _tiles;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _tiles = new List<GameObject>(row * column);
        
        for (int x = 0; x < column; x++)
        {
            for (int y = 0; y < row; y++)
            {
                _tiles.Add(GameObject.Instantiate(_tilePrefab, new Vector3(x, y, 0), Quaternion.identity, transform));
            }
        }

        foreach (var tile in _tiles)
        {
            Debug.Log(tile.transform.position);
        }

        Camera.main.transform.position = _tiles[_tiles.Count / 2].transform.position;
        Camera.main.transform.position -= 10*Vector3.forward;
    }
    
}
