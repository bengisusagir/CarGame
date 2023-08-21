using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.UI;

public class carcontrol : MonoBehaviour
{

    public GameObject car,baslangic;
    public float speed = 10f;
    public TextMeshProUGUI time,cantext,distance,panel;
    public float counter;
    public float can = 3;
    public int mesafe;
    private Rigidbody rb;
    bool oyunDevam = true;
    public GameObject fin;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        int mesafe = (int)Mathf.Abs(car.transform.position.z - baslangic.transform.position.z);
            distance.text = "Distance: " + mesafe;
        if (can != 0)
        {
            Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            Vector3 speedvector = playerInput * Time.deltaTime * speed;
            transform.Translate(speedvector);
            
        }
        
        else
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            oyunDevam = false;
            panel.text = "Your Skor:\n" + mesafe + " m\n" + (int)counter + " seconds";
            fin.SetActive(true);

        }
        

    }
    private void Update()
    {
        if (oyunDevam) { 
        counter += Time.deltaTime;
        time.text = "Time: " + (int)counter;}
    }
    private void OnCollisionEnter(Collision other)
    {
        string obj = other.gameObject.tag;
        if (obj.Equals("bitis"))
        {
            oyunDevam = false;
            panel.text = "Congratulations, you finished";
        }
        else if (obj.Equals("cars"))
        {
                can -= 1;
                cantext.text = "Health: " + can;
            }

       
        }
    }

