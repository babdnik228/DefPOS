using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public Transform shotPoint;
    public GameObject arrowPrefab;
    public float shotInterval;
    public float shotTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(shotTimer > 0)
        {
            shotTimer -= Time.deltaTime;
        }
        if(Input.GetMouseButtonDown(0))
        {
            // ���������� ����� � ������������ �����
            // �� ������� ��������� ���� (���)
            Vector3 mouseScreenPos = Input.mousePosition;
            // �������� ������� ��������� ����
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(mouseScreenPos);
            // ������� ����
            Vector3 bowPos = transform.position;
            // �������� ����������� �������
            Vector3 wantedDirection = mousePos - bowPos;
            // ����������� �������� �� ���������
            Vector3 defaultDirection = Vector2.right;

            float angle = Vector2.SignedAngle(defaultDirection, wantedDirection);
            Vector3 newEuler = new Vector3(0, 0, angle);
            transform.localEulerAngles = newEuler;
            if(shotTimer <= 0)
            {
                Instantiate(arrowPrefab, shotPoint.position,shotPoint.rotation);
                shotTimer = shotInterval;
            }
        }
    }
}
