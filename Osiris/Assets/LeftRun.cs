using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRun : MonoBehaviour
{
    public float speed = 5f; // ????????? ???? ?????
    public float lifetime = 10f; // ??? ????????? ??'????

    void Start()
    {
        // ???????????? ??????? ??? ???????? ??'???? ????? lifetime ??????
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        // ??? ??'???? ?????
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}