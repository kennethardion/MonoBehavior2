using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFunction : MonoBehaviour
{
    public void OnTriggerStay2d(Collider2D collider)
    {
        Debug.Log(collider.gameObject.name + " enter");
    }
}
