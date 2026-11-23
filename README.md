# MG7
## Devlog
Write your Devlog here. :3
Gaozan Ye
he/him,
My TreeOfBirds script uses an array to store and manage four Sparrow GameObjects. I put these birds in the array so the script can handle them together without repeating the same code. Every frame, a foreach loop checks each bird in the array. Vector3.Distance calculates the distance between the player’s position and each bird’s position. When that distance is smaller than the interaction distance, the script uses SetActive(true) to activate the bird. Activating the bird also starts its pop-up behavior through the Bird component. This makes the birds appear when the player approaches the tree and makes the environment feel more responsive and interactive.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
