using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BtnModel : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool Clicked { get; private set; } = false;

    public void OnPointerDown(PointerEventData eventData) => Clicked = true;

    public void OnPointerUp(PointerEventData eventData) => Clicked = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}
