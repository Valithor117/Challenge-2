using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp1 : MonoBehaviour
{
    public Transform Start;

    public Transform End;
     

    private void Update()
    {
         transform.position = Vector2.Lerp(Start.position, End.position, Mathf.PingPong(Time.time, 1.0f));
    }
}
