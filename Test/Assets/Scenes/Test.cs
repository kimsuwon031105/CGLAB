using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Hello Unity");
        int level = 10;
        float health = 10.5f;
        string name = "Hero";
        bool check = false;


        Debug.Log("What is your name?");
        Debug.Log(name);
        Debug.Log("�� ���� ���̾�?");
        Debug.Log(level);
        Debug.Log("�� ü���� ���̾�?");
        Debug.Log(health);

        List<string> item = new List<string>();
        item.Add("��¿");
        item.Add("Ƽ��");

        Debug.Log(item[0]);
    }


}
