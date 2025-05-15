using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonaCubos : MonoBehaviour
{
    public GameObject cuboPrefab; 


    // Start is called before the first frame update
    void Start()
    {
        //Instancia el cubo 
        Instantiate(cuboPrefab);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClonarCubo()
    {

    }
}
