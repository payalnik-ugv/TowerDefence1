using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public Castle castle;

    // Start is called before the first frame update
    void Start()
    {
        castle = GetComponent<Castle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
