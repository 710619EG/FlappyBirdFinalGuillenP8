using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    private void OnTrigger2D (Collider2D other)
    {
        if (other.GetComponent<Bird> () != null)
        {
            GameControl.instance.BirdScored();
        }
    }
}
