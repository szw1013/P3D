
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//门打开
public class DoorBox : MonoBehaviour
{

    public Vector3 eul;
    public Vector3 StartEul;
    public Vector3 CurrentEul;

    public bool IsOn;

    public Transform door;

    private void Awake()
    {
        //StartEul = door.localEulerAngles;
        //CurrentEul= door.localEulerAngles;
        //eul = StartEul -= Vector3.up * 90;
    }

    private void Update()
    {
        CurrentEul = IsOn ? Vector3.Lerp(CurrentEul, eul, Time.deltaTime * 5) : Vector3.Lerp(CurrentEul, StartEul, Time.deltaTime * 5);
        door.transform.eulerAngles = CurrentEul;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            IsOn = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            IsOn = false;
        }
    }
}
