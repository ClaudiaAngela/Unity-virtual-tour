using UnityEngine;
using UnityEngine.InputSystem; // Adăugăm librăria pentru noul sistem

public class RotireCamera : MonoBehaviour
{
    public float vitezaRotatie = 0.2f;
    private float yaw = 0f;
    private float pitch = 0f;

    void Update()
    {
        // Verificăm dacă există un mouse și dacă facem click stânga
        if (Mouse.current != null && Mouse.current.leftButton.isPressed)
        {
            // Citim cât de mult s-a mișcat mouse-ul pe ecran
            Vector2 delta = Mouse.current.delta.ReadValue();

            yaw += vitezaRotatie * delta.x;
            pitch -= vitezaRotatie * delta.y;

            // Limităm privirea sus-jos
            pitch = Mathf.Clamp(pitch, -90f, 90f);

            transform.eulerAngles = new Vector3(pitch, yaw, 0f);
        }
    }
}
