using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //Start click
    [SerializeField] private GameObject particle_Start;
    [SerializeField] private GameObject mus_Start;
    [SerializeField] private GameObject black;
    public void StartClick()
    {
        StartCoroutine(Start_Cor_Click());
    }
    private IEnumerator Start_Cor_Click()
    {
        GameObject startPart = Instantiate(particle_Start, transform.position, Quaternion.identity);
        GameObject musStart = Instantiate(mus_Start, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1);
        black.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
