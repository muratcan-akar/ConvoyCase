using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kontrol : MonoBehaviour
{
    public float YanaGitmeHizi;
    public float hiz;
    public int serit;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

        YanaGitmeHizi = 0;
        serit = 3;


    }
  
    IEnumerator Hizzala()
    {
        yield return new WaitForSeconds(.6F);
        YanaGitmeHizi = 0;

    }
    public void SagaGit()
    {
        if (serit < 6)
        {
            serit++;
            YanaGitmeHizi = 200 f;
            StartCoroutine(Hizzala());
        }
    }
    public void SolaGit()
    {
        if (serit > 0){
           serit--;
            YanaGitmeHizi = -200f;
            StartCoroutine(Hizzala());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       
       rb.velocity = new Vector3(hiz*Time.deltaTime, 0, YanaGitmeHizi * Time.deltaTime);
    }
}
