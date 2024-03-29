using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public float fadeOutTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (SpriteFadeOut (GetComponent<SpriteRenderer>()));
    }

    IEnumerator SpriteFadeOut(SpriteRenderer _sprite )
    {
        Color tmpColor = _sprite.color;

        while (tmpColor.a > 0f )
        {
            tmpColor.a -= Time.deltaTime / fadeOutTime;
            _sprite.color = tmpColor;

            if (tmpColor.a <= 0f)
                tmpColor.a = 0.0f;
            yield return null;
        }
        _sprite.color = tmpColor;
    }
}
