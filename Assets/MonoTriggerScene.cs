using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoTriggerScene : MonoBehaviour
{
    public class PlayerController : MonoBehaviour
    {
        public string PlayerName;
        public int HP;
        public int DMG;
        private const float Speed = 50f;
        Rigidbody2D rb;
        float jumpforce = 10f;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        public void AddForce()
        {
            rb.AddForce(Vector2.up * 5f, ForceMode2D.Impulse);
        }
        public void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("TRG Enter succes");
        }
        public void OnTriggerExit2D(Collider2D collision)
        {
            Debug.Log("TRG Exit success");
        }
        public void OnTriggerStay2D(Collider2D collision)
        {
            Debug.Log("TRG Stay success");
        }
        private void OnMouseDown()
        {
            rb.AddForce(new Vector2(0f, jumpforce) * 5f, ForceMode2D.Impulse);
        }

    } 
}