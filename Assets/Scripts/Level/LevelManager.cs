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
        
        public static int lastDirection = 1;
        
        private Vector3 _spawnPosition = new Vector3(0, 0, 0);
        private float _planeLenght = 100;

        private void Start()
        {
            GameObject plane = Instantiate(StartPlane);
            plane.transform.position = _spawnPosition + new Vector3(0, 0, 0);
            _spawnPosition = plane.transform.position;
            //SpawnPlane();
            //Instantiate(EndPlane);
        }

        private void Update()
        {
            SpawnPlane();
        }

        public void SpawnPlane()
        {
            //int count = Random.Range(MinCount, MaxCount);

            //for (int i = 0; i < count; i++)
            {
                int randomDirection = Random.Range(0, 2);
                var randomPlane = Random.Range(0, PlanePrefabs.Length);
                //var direction = transform.forward * _spawnPosition + new Vector3(_planeLenght, 0, 0);
                

                if (randomDirection == 0)
                {
                    if (lastDirection == 0)
                    {
                        GameObject plane = Instantiate(PlanePrefabs[randomPlane]);
                        plane.transform.position = _spawnPosition + new Vector3(_planeLenght, 0, 0);
                        //plane.transform.Rotate(0, 90, 0);
                        _spawnPosition = plane.transform.position;   
                    }
                    else
                    {
                        GameObject plane = Instantiate(PlanePrefabs[randomPlane]);
                        plane.transform.position = _spawnPosition + new Vector3(_planeLenght / 2 - 5, 0, -(_planeLenght / 2) + _planeLenght);
                        //plane.transform.Rotate(0, 90, 0);
                        _spawnPosition = plane.transform.position;    
                    }
                    lastDirection = randomDirection;
                }
                else
                {
                    if (lastDirection == 0)
                    {
                        GameObject plane = Instantiate(PlanePrefabs[randomPlane]);
                        plane.transform.position = _spawnPosition + new Vector3(_planeLenght / 2 + _planeLenght, 0, _planeLenght + _planeLenght / 2);
                        _spawnPosition = plane.transform.position;
                    }
                    else
                    {
                        GameObject plane = Instantiate(PlanePrefabs[randomPlane]);
                        plane.transform.position = _spawnPosition + new Vector3(0, 0, _planeLenght);
                        _spawnPosition = plane.transform.position;    
                    }
                    
                    lastDirection = randomDirection;
                }
            }
        }
    }
}
