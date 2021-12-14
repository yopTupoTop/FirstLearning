using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Level
{
    public class LevelManager : SerializedMonoBehaviour
    {
        public GameObject[] PlanePrefabs;
        public GameObject StartPlane;
        
        public static int LastDirection = 1;
        
        private Vector3 _spawnPosition = new Vector3(0, 0, 0);
        private float _planeLenght = 100;

        private void Start()
        {
            GameObject plane = Instantiate(StartPlane);
            plane.transform.position = _spawnPosition + new Vector3(0, 0, 0);
            _spawnPosition = plane.transform.position;

            InvokeRepeating("SpawnPlane", 0.5f, 0.5f);
        }

        public void SpawnPlane()
        {
                int randomDirection = Random.Range(0, 2);
                var randomPlane = Random.Range(0, PlanePrefabs.Length);
                GameObject plane;
                
                if (randomDirection == 0)
                {
                    if (LastDirection == 0)
                    {
                        plane = Instantiate(PlanePrefabs[randomPlane]);
                        plane.transform.position = _spawnPosition + new Vector3(_planeLenght, 0, 0);
                        _spawnPosition = plane.transform.position;   
                    }
                    else
                    {
                        plane = Instantiate(PlanePrefabs[randomPlane]);
                        plane.transform.position = _spawnPosition + new Vector3(_planeLenght / 2 - 5, 0, _planeLenght / 2);
                        _spawnPosition = plane.transform.position;    
                    }
                    LastDirection = randomDirection;
                }
                else
                {
                    if (LastDirection == 0)
                    {
                        plane = Instantiate(PlanePrefabs[randomPlane]);
                        plane.transform.position = _spawnPosition + new Vector3(_planeLenght / 2 - 5, 0, _planeLenght + 5);
                        _spawnPosition = plane.transform.position;
                    }
                    else
                    {
                       
                        plane = Instantiate(PlanePrefabs[randomPlane]);
                        plane.transform.position = _spawnPosition + new Vector3(0, 0, _planeLenght);
                        _spawnPosition = plane.transform.position;    
                    }
                    
                    LastDirection = randomDirection;
                }
                
                Destroy(plane, 2f);
        }

    }
}
