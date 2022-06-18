using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicGamePlay : MonoBehaviour
{
    //Позиция
    [SerializeField] private bool is_pos_x;
    [SerializeField] private bool is_pos_y;
    //
    public bool is_left = false;
    public bool is_right = false;
    public bool is_up = false;
    public bool is_down = false;
    //
    public bool is_activate;
    //
    [SerializeField] private GameObject mus_prefab;
    [SerializeField] private GameObject part_prefab;


    private void Start()
    {
        is_activate = false;
    }
    private void OnMouseDown()
    {
        GameObject partprefab = Instantiate(part_prefab, transform.position, Quaternion.identity);
        Destroy(partprefab, 3f);
        GameObject musPrefab = Instantiate(mus_prefab, transform.position, Quaternion.identity);
        Destroy(musPrefab, 3f);
        is_activate = true;
        GetComponent<Rigidbody>().isKinematic = false;
    }
    private void Update()
    {
        if(is_activate == true)
        {
            Move();
        }
    }
    private void Move()
    {
        if(is_pos_x == true)
        {
            if(is_left == true)
            {
                transform.position += transform.right * -2 * Time.deltaTime;
            }
            if(is_right == true)
            {
                transform.position += transform.right * 2 * Time.deltaTime;
            }
        }
        if(is_pos_y == true)
        {
            if(is_up == true)
            {
                transform.position += transform.forward * 2 * Time.deltaTime;
            }
            if(is_down == true)
            {
                transform.position += transform.forward * -2 * Time.deltaTime;
            }
        }
    }

}
