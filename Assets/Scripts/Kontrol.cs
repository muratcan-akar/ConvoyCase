using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kontrol : MonoBehaviour
{
    public float YanaGitmeHizi;
    public float hiz;
    public OyunYoneticisi oyunYoneticisi;
    public int serit;
    public ParticleSystem Efek;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
      

        YanaGitmeHizi = 0;
        serit = 3;
        Efek.Stop(true);


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Dusman")
        {
            oyunYoneticisi.KaybetmeEkrani();
            Invoke("KarekterYokEt", 0.3f);
            Efek.Play(true);
        }
        if (other.gameObject.tag == "Finish")
        {
            oyunYoneticisi.KazanmaEkrani();
        }
    }
    public void KarekterYokEt()
    {
        Destroy(this.gameObject);
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
            YanaGitmeHizi = 170f;
            StartCoroutine(Hizzala());
        }
    }
    public void SolaGit()
    {
        if (serit > 0){
           serit--;
            YanaGitmeHizi = -170f;
            StartCoroutine(Hizzala());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       
       rb.velocity = new Vector3(hiz*Time.deltaTime, 0, YanaGitmeHizi * Time.deltaTime);
    }
}
