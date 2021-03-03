using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanOlusturucu : MonoBehaviour
{
    public GameObject DusmanObjesi;
    public Transform Player;
    public float RandomZ;
 
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Olustur());

    }
    IEnumerator Olustur()
    {
        
        RandomZ = Random.Range(-10,10);
        Vector3 OlusturmaNoktasi = new Vector3(Player.position.x+135, transform.position.y, RandomZ);
        yield return new WaitForSeconds(2f);
        Instantiate(DusmanObjesi, OlusturmaNoktasi,Quaternion.identity);
        StartCoroutine(Olustur());

    }


    

    // Update is called once per frame
    void Update()
    {
      
    }
}
