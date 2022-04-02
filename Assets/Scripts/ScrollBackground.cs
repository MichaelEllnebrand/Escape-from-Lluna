using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBackground : MonoBehaviour
{
    [SerializeField] private RawImage _image;
    [SerializeField] private float _scrollAmountX;
    [SerializeField] private float _scrollAmountY;

    void Update()
    {
        _image.uvRect = new Rect(_image.uvRect.position + new Vector2(_scrollAmountX, _scrollAmountY) * Time.deltaTime, _image.uvRect.size);
    }

}
