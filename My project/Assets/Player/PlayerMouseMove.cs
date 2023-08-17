using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float sensitivity = 2.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        currentX += mouseX;
        currentY -= mouseY;

        // �÷��̾� ȸ�� (Y�� ȸ���� ����)
        transform.rotation = Quaternion.Euler(currentY, currentX, 0);

        // �÷��̾� �̵� (�̵� ������ ȸ���� ������� �ʰ� ����)
        Vector3 moveDirection = new Vector3(moveX, 0, moveZ);
        moveDirection = Quaternion.Euler(currentY, currentX, 0) * moveDirection;
        moveDirection.Normalize(); // �̵� ������ ����ȭ�Ͽ� ���� �ӵ��� �̵�
        moveDirection *= moveSpeed * Time.deltaTime;

        transform.position += moveDirection;
    }
}
