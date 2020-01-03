using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;
    public Text winText;


    private int scord;
    


    Vector2 movement;
    Vector2 mousePos;

    void Start()
    {
        scord = 0;
        Scord();
        winText.text = "";
    }


    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

     void OnTriggerEnter2D(Collider2D other)
      {
        if (other.gameObject.CompareTag("star"))
        {
            other.gameObject.SetActive(false);
            scord = scord + 1;
            Scord ();
        }
     }

    void Scord ()
    {
        if (scord >= 3)
        {
            winText.text = "MISSION COMPLETE";
        }
    }
}
