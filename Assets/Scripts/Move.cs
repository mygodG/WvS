using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    private void OnMouseUp()
    {
        if(this.tag != "sheep" && this.tag != "wolf")
        {
            print("This is not an animal!");
            return;
        }

        if (GameManager.instance.flag == 0)
        {
            GameManager.instance.flag = 1;
            GameManager.instance.SelectAnimal(this.gameObject);
        }
        else
        {
            GameManager.instance.flag = 0;
            GameManager.instance.SelectAnimal(null);
        }
    }
}
