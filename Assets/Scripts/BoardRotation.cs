using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardRotation : MonoBehaviour
{
    [SerializeField]
    private float m_RotationSpeed = 5.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if(transform.rotation.eulerAngles.z <= 35)
            {
                gameObject.transform.Rotate(0, 0, m_RotationSpeed * Time.deltaTime);
            }

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(transform.rotation.eulerAngles.z >= -35)
            {
                gameObject.transform.Rotate(0, 0, -m_RotationSpeed * Time.deltaTime);
            }

        }
    }
}
