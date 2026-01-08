using UnityEngine;

public class PressurePlateGroup : MonoBehaviour
{
    // Track the state of each plate
    private bool[] plateStates = new bool[3];

    // The object or component to enable
    [SerializeField] private GameObject thingToEnable;

    // Called by pressure plates
    public void OnPlatePressed(int plateIndex)
    {
        if (IsValidIndex(plateIndex))
        {
            plateStates[plateIndex] = true;
            UpdateState();
        }
    }

    // Called by pressure plates
    public void OnPlateReleased(int plateIndex)
    {
        if (IsValidIndex(plateIndex))
        {
            plateStates[plateIndex] = false;
            UpdateState();
        }
    }

    private void UpdateState()
    {
        bool allPressed = plateStates[0] && plateStates[1] && plateStates[2];
        thingToEnable.SetActive(allPressed);
    }

    private bool IsValidIndex(int index)
    {
        return index >= 0 && index < plateStates.Length;
    }
}
