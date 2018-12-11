using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour {

    public int columns = 5;
    public int rows    = 5;

    public GameObject grass;
    public GameObject wall;
    public GameObject sheep;
    public GameObject wolf;

    private Transform boardHolder;

    public void BoardSetup()
    {
        boardHolder = new GameObject("Board").transform;
        for(int x = -2; x < columns * 2 + 2; x+=2)
        {
            for(int y = -2; y < rows * 2 + 2; y+=2)
            {
                GameObject toInstantiate = grass;
                if(x == -2 || x == columns * 2|| y == -2 || y == rows * 2)
                {
                    toInstantiate = wall;
                }

                GameObject instance = Instantiate(toInstantiate, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
                instance.transform.SetParent(boardHolder);
            }
        }

        for (int x = 0; x < 10; x += 2)
        {
            for (int y = 0; y < 4; y += 2)
            {
                GameObject instance1 = Instantiate(sheep, new Vector3(x, y, -5f), Quaternion.identity) as GameObject;
                instance1.transform.SetParent(boardHolder);
            }
        }
        GameObject instance2 = Instantiate(wolf, new Vector3(2, 8, -5), Quaternion.identity) as GameObject;
        instance2.transform.SetParent(boardHolder);
        GameObject instance3 = Instantiate(wolf, new Vector3(6, 8, -5), Quaternion.identity) as GameObject;
        instance3.transform.SetParent(boardHolder);
    }
}
