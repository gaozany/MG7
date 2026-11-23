using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private GameObject[] _sparrows;
    [SerializeField] private Transform _player;
    [SerializeField] private float _interactionDistance = 5f;

    private void Update()
    {
        foreach (GameObject sparrow in _sparrows)
        {
            float distance = Vector3.Distance(
                _player.position,
                sparrow.transform.position
            );

            if (distance <= _interactionDistance)
            {
                sparrow.SetActive(true);
            }
        }
    }
}