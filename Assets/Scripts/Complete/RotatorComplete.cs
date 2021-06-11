using UnityEngine;

public class RotatorComplete : MonoBehaviour
{
    Vector3 euler = Vector3.zero;

    void Update()
    {
        // ‰ñ“]‘¬“xi‚P•bŠÔ‚É‚S‚T“x‰ñ“]j
        euler.z = 45f * Time.deltaTime;

        // ‚±‚±‚É–½—ß‚ğ’Ç‰Á
        transform.Rotate( euler );
    }

}
