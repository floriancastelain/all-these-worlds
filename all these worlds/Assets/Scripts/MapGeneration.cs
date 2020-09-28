using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{

    public int mapXLenght;
    public int mapYLength;

    public GameObject tile;

    void GenerateMap(int maxX, int maxY) {
        for (int x=0; x <= maxX; x++) {
            for (int y=0; y <= maxY; y++) {
                Instantiate(tile, new Vector3(10*x,0,10*y), Quaternion.identity);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        GenerateMap(mapXLenght, mapYLength);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
