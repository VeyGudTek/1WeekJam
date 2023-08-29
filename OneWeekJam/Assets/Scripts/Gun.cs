using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public List<GameObject> bullet_list = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject temp_bullet = Instantiate(bullet, transform.position, transform.rotation);
            bullet_list.Add(temp_bullet);
        }

        foreach (var temp in new List<GameObject>(bullet_list))
        {
            if (temp.GetComponent<Bullet>().hit)
            {
                Debug.Log("If Executed");
                bullet_list.Remove(temp);
                Destroy(temp);
            }
        }
    }
}
