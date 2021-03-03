using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OyunYoneticisi : MonoBehaviour
{
    public GameObject KaybettinEkrani;
    public GameObject KazandinizEkrani;
    // Start is called before the first frame update
    void Start()
    {
        KaybettinEkrani.SetActive(false);
        KazandinizEkrani.SetActive(false);
    }

    public void KazanmaEkrani()
    {
        KazandinizEkrani.SetActive(true);
        Time.timeScale = 0;
    }
    public void KaybetmeEkrani()
    {
        Invoke("KaybetmeEkraniCikar", 1f);

    }
    public void KaybetmeEkraniCikar()
    {
        KaybettinEkrani.SetActive(true);
    }
    public void YenidenBaslatButonu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("AnaEkran");
    }

    // Update is called once per frame
    
}
