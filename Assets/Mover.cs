using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // basic note for moving or adding colors for the object in the world we create scripte and matierals and attach them . 
    // in order to the data to unity we can add serilized field 
  //  [SerializeField] private float xValue = 0.01f;
  //  [SerializeField]  private float yValue = 0;
    //[SerializeField] private float zValue = 0;
    // Start is called before the first frame update
    
    [SerializeField] private float moveSpeed = 10f;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed ;
        //float yValue = Input.GetAxis("");
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed; // Time.DeltaTime make the game frame indepndent :D 

        transform.Translate(xValue  , 0 , zValue); // we try to access the tranform in the object .translate make it move to spicific location 
        
    }
}
