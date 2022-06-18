using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject start_blackPrewiew;
    private void Start()
    {
        start_blackPrewiew.SetActive(true);
        Destroy(start_blackPrewiew, 6f);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
