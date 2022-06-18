using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject mus_Finish;
    [SerializeField] private GameObject anim_setTr;
    [SerializeField] private int NameScene;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Cor_Finish());
        }
    }
    
    private IEnumerator Cor_Finish()
    {
        GameObject musFinish = Instantiate(mus_Finish, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(5f);
        anim_setTr.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(NameScene);

    }
}
