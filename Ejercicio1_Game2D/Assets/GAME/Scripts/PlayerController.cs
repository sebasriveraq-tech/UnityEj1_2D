using UnityEngine;
using UnityEngine.InputSystem; // Importante para el nuevo Input System

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f;

    private Rigidbody2D rb;
    private float movimientoH;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movimientoH = 0f;

        // Leemos las teclas directamente con el nuevo Input System
        if (Keyboard.current != null)
        {
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
            {
                movimientoH = -1f;
            }
            else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
            {
                movimientoH = 1f;
            }
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(movimientoH * velocidad, rb.linearVelocity.y);
    }
}