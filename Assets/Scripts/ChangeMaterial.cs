using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Create a Script that change the color of sphere with button in UI

    // Start is called before the first frame update
    public GameObject sphere;
    public Material material1;
    
    public void ChangeColorObject()
    {
        Debug.Log("cambiando color");
        sphere.GetComponent<MeshRenderer> ().material = material1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
