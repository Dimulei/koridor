using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour
{
    public float verta;
    public float horizon;
    public int speed;
    private Rigidbody rc;
    public float space;
    // Start is called before the first frame update
    void Start()
    {
        rc = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        verta = Input.GetAxis("Vertical");
        horizon= Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verta);
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizon);
        if (Input.GetKey(KeyCode.Space)) 
        {
            rc.AddForce(Vector3.up * space, ForceMode.Impulse);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("up"))
        {
            transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("money"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("stope"))
        {
            transform.localScale += new Vector3(-0.5f, -0.5f, -0.5f);
            Destroy(collision.gameObject);
        }   
    }
}
