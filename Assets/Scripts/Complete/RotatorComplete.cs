using UnityEngine;

public class RotatorComplete : MonoBehaviour
{
    Vector3 euler = Vector3.zero;

    void Update()
    {
        // ��]���x�i�P�b�ԂɂS�T�x��]�j
        euler.z = 45f * Time.deltaTime;

        // �����ɖ��߂�ǉ�
        transform.Rotate( euler );
    }

}
