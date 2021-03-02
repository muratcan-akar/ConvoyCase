using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escort : MonoBehaviour
{
    public Transform Player;
    public float Aralik;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerVectoru = new Vector3(transform.position.x, transform.position.y, Player.position.z);

        transform.position = Vector3.Lerp(transform.position, playerVectoru, 1.2f * Time.deltaTime);
        transform.position = new Vector3(Player.transform.position.x+Aralik, transform.position.y, transform.position.z);
    }
}
