using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameramovement : MonoBehaviour
{
    //object to link 
    GameObject meteors;
    public Text myText;
    //object to clone
    public Transform target;
    public int PlayerScore = 0;
    public GameObject objToSpawn;
    //helping variates using by other scripts
    public int met=0;
    public int sun=0;
    public int cam=0;
    public int plan=0;
    
    // Update is called once per frame 
    //movements of cammera
    void Update()
    {
        Vector3 place = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += gameObject.transform.forward * Time.deltaTime * 4;

        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position -= gameObject.transform.forward * Time.deltaTime * 4;
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position -= gameObject.transform.right * Time.deltaTime * 4;
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += gameObject.transform.right * Time.deltaTime * 4;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            gameObject.transform.position += gameObject.transform.up * Time.deltaTime * 4;
        }
        if (Input.GetKey(KeyCode.X))
        {
            gameObject.transform.position -= gameObject.transform.up * Time.deltaTime * 4;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.RotateAround(target.transform.position, gameObject.transform.up, 4 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.RotateAround(target.transform.position, gameObject.transform.up, -4 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.RotateAround(target.transform.position, gameObject.transform.right, 4 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.RotateAround(target.transform.position, gameObject.transform.right, -4 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.I))
        {
            gameObject.transform.LookAt(target);
        }
        //meteor spawing in the view of camera
        if (Input.GetKeyDown(KeyCode.Space))
        {
            meteors = Instantiate(objToSpawn, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
        
        findScore();

        ///printing the score
        myText.text = "Player Score: " + PlayerScore;
        //set the variates to 0
        met = 0;
        cam = 0;
        plan = 0;
        sun = 0;
        //quiting from application
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    //helping method for the score
    void OnTriggerEnter(Collider n)
    {
        cam++;
    }
    //method for the score count
    void findScore() { 
    if(cam==1 && plan == 1) { PlayerScore--; }
    if (cam == 1 && sun == 1) { PlayerScore--; }
    if (met == 1 && plan == 1) { PlayerScore++; }
    }
    
}
