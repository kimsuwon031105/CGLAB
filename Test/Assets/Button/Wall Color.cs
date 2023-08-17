using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeWallColor : MonoBehaviour
{
    public Color32 LightBlue = new Color32(185, 217, 212, 255);
    public Color32 Pink = new Color32(238, 190, 190, 255);
    public Color[] colors;

    int colorIndex = 0;
    bool enableColorChange = false;

    private Renderer wallRenderer;
    


    void Start()
    {
        // LightBlue�� Pink�� colors �迭�� �߰�
        colors = new Color[] { Color.red, Color.blue, Color.green, LightBlue, Pink };

        // WallF�� WallL �̸��� GameObject�� ã��
        GameObject changer = GameObject.Find("Wall");
 


        if (changer != null)
        {
            wallRenderer = changer.GetComponent<Renderer>();
        }


    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            enableColorChange = true; // ���콺 Ŭ�� �� ���� ���� Ȱ��ȭ
        }
    }

    void OnMouseDown()
    {
        if (enableColorChange)
        {
            ChangeColor();
            enableColorChange = false; // ���� ���� �� �ٽ� ��Ȱ��ȭ
        }
    }

    void ChangeColor()
    {
        // ���� �������� ����
        colorIndex = (colorIndex + 1) % colors.Length;

        // WallF�� WallL�� ������ ������Ʈ�� ���� ���� ����
        if (wallRenderer != null)
        {
            wallRenderer.material.color = colors[colorIndex];
        }

        

    }
}