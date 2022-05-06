using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;

    // Start is called before the first frame update
  
    public void InstiantateCube()
    {
        int counter = 0;
        while (counter < 3)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
