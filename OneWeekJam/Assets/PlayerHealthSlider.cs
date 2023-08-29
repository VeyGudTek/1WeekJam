using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthSlider : MonoBehaviour
{
    public GameObject manager;
    private GameManager managerScript;
    // Start is called before the first frame update
    void Awake()
    {
        managerScript = manager.GetComponent<GameManager>();
        gameObject.GetComponent<Slider>().value = 0.5f;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
