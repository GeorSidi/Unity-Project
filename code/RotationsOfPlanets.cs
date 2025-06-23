using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationsOfPlanets : MonoBehaviour
{
    public GameObject k;
    public GameObject sound;
    // Start is called before the first frame update
    void Start()
    {
        k = GameObject.Find("Camera");
    }
    
    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "P1")
        {
            transform.Rotate(0, 1.8f, 0);//rotate from himself
            transform.RotateAround(Vector3.zero, Vector3.down, 15 * Time.deltaTime);//rotate from sun(0,0,0)
        }
        else if (gameObject.name == "P2")
        {
            transform.Rotate(0, 1.5f, 0);
            transform.RotateAround(Vector3.zero, Vector3.down, 13 * Time.deltaTime);
        }else if (gameObject.name == "P3")
        {
            transform.Rotate(0, 1.2f, 0);
            transform.RotateAround(Vector3.zero, Vector3.down, 11 * Time.deltaTime);
        }else if (gameObject.name == "P4")
        {
            transform.Rotate(0, 0.8f, 0);
            transform.RotateAround(Vector3.zero, Vector3.down, 9 * Time.deltaTime);
        }
        if (gameObject.name == "P5")
        {
            transform.Rotate(0, 0.4f, 0);
            transform.RotateAround(Vector3.zero, Vector3.down, 7 * Time.deltaTime);
        }
        if (gameObject.name == "Sun")
        {
            transform.Rotate(0, 0.005f, 0);
        }
    }

    void OnTriggerEnter(Collider n)
    {
        
        if (gameObject.name != "Sun" )
        {
            k.GetComponent<cameramovement>().plan++;
            Destroy(this.gameObject);
            sound= Instantiate(sound, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
        if (gameObject.name == "Sun")
        {
            k.GetComponent<cameramovement>().sun++;
        }
    
    }
    
}
