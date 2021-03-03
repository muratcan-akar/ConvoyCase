using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escort : MonoBehaviour
{
    public Transform Player;
    public float AralikX;
    public float AralikZ;
    public ParticleSystem Efek;
    public bool carptý = false;
   
    // Start is called before the first frame update
    void Start()
    {
        Efek.Stop(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Dusman")
        {

            Efek.Play(true);
            Invoke("EscordYokET", 0.3f);
        }
    }
    public void EscordYokET()
    {
        Destroy(this.gameObject);
    }
   

    // Update is called once per frame
    void Update()
    {
        Vector3 playerVectoru = new Vector3(transform.position.x, transform.position.y, Player.position.z+AralikZ);

        transform.position = Vector3.Lerp(transform.position, playerVectoru,3f * Time.deltaTime);
        transform.position = new Vector3(Player.transform.position.x+AralikX, transform.position.y, transform.position.z);
    }
}
