using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickPhone : MonoBehaviour
{

    public bool message = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("object triggered by " + gameObject.name);
        message = true;

    }


}
