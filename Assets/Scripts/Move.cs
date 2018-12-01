using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    private void OnMouseUpAsButton()
    {
        print("This is " + this.tag);
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            GameManager.instance.SelectAnimal(hit.collider.gameObject);
        }
    }
}
