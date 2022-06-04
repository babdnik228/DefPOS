using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform shootPoint;

    public float shootInterval = 0.75f;
    public float shootTimer = 0;

    void Update()
    {
        if (shootTimer > 0)
        {
            shootTimer -= Time.deltaTime;
        }

        if (Input.GetMouseButton(0) == true)
        {
            #region Алгоритм поворота

            // Определяем точку в пространстве сцены
            // на которую указывает мышь (тач)
            Vector3 mouseScreenPos = Input.mousePosition;
            // Реальная позиция указателя мыши
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(mouseScreenPos);
            // Позиция лука
            Vector3 bowPos = transform.position;

            // Желаемое направление взгляда
            Vector3 wantedDirection = mousePos - bowPos;
            // направление вращения по умолчанию
            Vector3 defaultDirection = Vector2.right;

            float angle = Vector2.SignedAngle(defaultDirection, wantedDirection);
            Vector3 newEuler = new Vector3(0, 0, angle);
            transform.localEulerAngles = newEuler;
            #endregion

            if (shootTimer <= 0)
            {
                Instantiate(arrowPrefab, shootPoint.position, shootPoint.rotation);
                shootTimer = shootInterval;
            }
        }
    }
}
