using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float time_value;
    public TextMeshProUGUI timer;
    // Start is called before the first frame update
    void Start()
    {
        time_value = 10f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time_value -= Time.deltaTime;
        timer.text = time_value.ToString("0");
        if (time_value <= 0)
        {
            SceneManager.LoadScene("End");
        }
    }
}
