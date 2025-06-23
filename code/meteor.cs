using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor : MonoBehaviour
{

    public float x;
    private GameObject k;
    public GameObject explosions;
    //public GameObject l;

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(1.0f, 5.0f);
        gameObject.transform.localScale = new Vector3(x, x, x);
        k = GameObject.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.forward * Time.deltaTime * 5;
    }

    void OnTriggerEnter(Collider n) {
        Destroy(this.gameObject);
        k.GetComponent<cameramovement>().met++;
        explosions= Instantiate(explosions, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }
}
