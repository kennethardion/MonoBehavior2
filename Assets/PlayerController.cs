using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string PlayerName;
    public int HP;
    public int DMG;
    private const float Speed = 50f;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision){
            Debug.Log("Enter success");
    }
    
    private void OnCollisionStay2D(Collision2D collision){
            Debug.Log("stay success");
    }

    private void OnCollisionExit2D(Collision2D collision){
            Debug.Log("exit success");
    }
    private void OnMouseDown()
    {
        rb.AddForce(Vector2.up * 5f, ForceMode2D.Impulse);
    }
}