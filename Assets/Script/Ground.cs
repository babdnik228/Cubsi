using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private GameObject particle_prefab;
    private void OnMouseDown()
    {
        Vector3 mousPos = Input.mousePosition;
        Vector3 mousWord = Camera.main.ScreenToWorldPoint(mousPos);
        GameObject prefab = Instantiate(particle_prefab, mousWord, Quaternion.identity);
        Destroy(prefab, 3f);
    }
}
