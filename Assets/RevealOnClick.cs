using UnityEngine;

public class RevealOnClick : MonoBehaviour
{
    public GameObject target;

    public void Reveal()
    {
        target.SetActive(true);
    }
}