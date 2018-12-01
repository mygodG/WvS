using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public BoardManager boardScript;
    public static GameManager instance = null;
    private GameObject selectedAnimal = null;

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
    void Start () {
        boardScript = GetComponent<BoardManager>();
        boardScript.BoardSetup();

    }
	
	// Update is called once per frame
	void Update () {
        if (selectedAnimal != null)
        {
            selectedAnimal.transform.position = Input.mousePosition;
        }
    }
}
