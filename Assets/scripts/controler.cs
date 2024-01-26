using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour
{
    public float verta;
    public float horizon;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verta = Input.GetAxis("Vertical");
        horizon= Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verta);
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizon);

    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("up"))
        {
            Destroy(collision.gameObject);
        }
    }
}
