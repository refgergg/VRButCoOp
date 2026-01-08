using UnityEngine;
using UnityEngine.Events;

public class PressurePlate : MonoBehaviour
{
    public UnityEvent onPressed;
    public UnityEvent onReleased;

    private int objectsOnPlate = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player") && !other.CompareTag("Box"))
            return;

        objectsOnPlate++;

        if (objectsOnPlate == 1)
        {
            onPressed.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player") && !other.CompareTag("Box"))
            return;

        objectsOnPlate--;

        if (objectsOnPlate <= 0)
        {
            objectsOnPlate = 0;
            onReleased.Invoke();
        }
    }
}
