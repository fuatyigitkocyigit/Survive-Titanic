using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingSFX : MonoBehaviour
{
    public enum TerrainType
    {
        Grass,
        Wood,
        Sand,
        Water,
        // add more as needed
    }

    [SerializeField]
    private AudioClip grassWalk;
    [SerializeField]
    private AudioClip woodWalk;
    [SerializeField]
    private AudioClip sandWalk;
    [SerializeField]
    private AudioClip waterWalk;
    // add more audio clips as needed


    private AudioSource walkSource;
    private CharacterController characterController;
    private TerrainType currentTerrain;

    private void Start()
    {
        walkSource = GetComponent<AudioSource>();
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        switch (currentTerrain)
        {
            case TerrainType.Grass:
                walkSource.clip = grassWalk;
                break;
            case TerrainType.Wood:
                walkSource.clip = woodWalk;
                break;
            case TerrainType.Sand:
                walkSource.clip = sandWalk;
                break;
            case TerrainType.Water:
                walkSource.clip = waterWalk;
                break;
                // add more cases as needed
        }

        if (!walkSource.isPlaying && characterController.velocity.magnitude > 0.1f)
        {
            walkSource.Play();
        }
        else if (walkSource.isPlaying && characterController.velocity.magnitude < 0.1f)
        {
            walkSource.Stop();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Grass":
                currentTerrain = TerrainType.Grass;
                break;

            case "Wood":
                currentTerrain = TerrainType.Wood;
                break;

            case "Sand":
                currentTerrain = TerrainType.Sand;
                break;

            case "Water":
                currentTerrain = TerrainType.Water;
                break;
        }
    }
}