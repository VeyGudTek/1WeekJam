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
            GameObject temp_bullet = Instantiate(bullet, transform.position + transform.forward * 2, transform.rotation);
            bullet_list.Add(temp_bullet);
            temp_bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000f);
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

        aim();

        if (Input.GetAxis("Horizontal") == 0)
        {
            transform.position = new Vector3(transform.position.x, 11.5f, transform.position.z);

        }
        else
        {
            transform.position = new Vector3(transform.position.x, 11.5f, transform.position.z);
        }
    }

    void aim()
    {

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(Camera.main.transform.position.z - transform.position.z)));
        
        transform.LookAt(mousePosition);
    }
}

