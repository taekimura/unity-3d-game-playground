using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    [SerializeField]
    private GameObject smokePrefab;

    [SerializeField]
    private GameObject planePrefab;

    [SerializeField]
    private GameObject supplyCratePrefab;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<GameManager>();

            }

            return instance;

        }
    }

    public GameObject SmokePrefab { get => smokePrefab; set => smokePrefab = value; }
    public GameObject SupplyCratePrefab { get => supplyCratePrefab; set => supplyCratePrefab = value; }

    public void SpawnPlane(Vector3 smokePosition)
    {
        Plane plane = Instantiate(planePrefab).GetComponent<Plane>();
        plane.Setup(smokePosition);
    }
}
