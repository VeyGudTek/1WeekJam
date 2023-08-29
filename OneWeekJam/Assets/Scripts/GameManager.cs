using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gun;
    private Gun gunScript;
    
    // Start is called before the first frame update
    void Awake()
    {
        gunScript = GetComponent<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
