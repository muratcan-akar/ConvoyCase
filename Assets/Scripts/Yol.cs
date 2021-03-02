using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yol : MonoBehaviour
{
    public Transform ArkamdaKalanYol;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            ArkamdaKalanYol.transform.position = new Vector3(ArkamdaKalanYol.position.x + 80f, ArkamdaKalanYol.position.y, ArkamdaKalanYol.position.z);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
