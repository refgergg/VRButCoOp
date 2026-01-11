using UnityEngine;
using UnityEngine.Events;

public class PressurePlate : MonoBehaviour
{
    public UnityEvent onPressed;
    public UnityEvent onReleased;

    private int objectsOnPlate = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player") && !other.gameObject.CompareTag("Box"))
        return;

        objectsOnPlate++;

        print("pressed by " + other.gameObject.name);

        if (objectsOnPlate == 1)
        {
            print("pressed by " + other.gameObject.name);
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
