using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public BoardManager boardScript;
    public static GameManager instance = null;
    private GameObject selectedAnimal = null;
    public int flag = 0;

    public void SelectAnimal(GameObject gameObject)
    {
        selectedAnimal = gameObject;
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () 
    {
        boardScript = GetComponent<BoardManager>();
        boardScript.BoardSetup();
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (null != selectedAnimal)
        {
            print(selectedAnimal.tag);
        }

        if (flag == 1)
        {
            selectedAnimal.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectedAnimal.transform.position = new Vector3(selectedAnimal.transform.position.x, selectedAnimal.transform.position.y, -5f);
            Debug.Log(selectedAnimal.transform.position);
        }

    }
}
