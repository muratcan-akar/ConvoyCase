using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    public float DusmanHizi;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DusmanSilici"|| other.gameObject.tag == "Player" || other.gameObject.tag == "Escort")
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(-DusmanHizi * Time.deltaTime, 0, 0);
    }
}
