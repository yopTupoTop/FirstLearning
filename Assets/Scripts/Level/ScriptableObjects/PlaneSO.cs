using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.Serialization;
using Sirenix.OdinInspector;

namespace Level.ScriptableObjects
{
   [CreateAssetMenu(fileName = "Plane", menuName = "ScriptableObject/PlaneSO", order = 1)]

   [Serializable]
   public class PlaneSO : ScriptableObject
   {
      public PlaneModel PlanePrefab;
      [OdinSerialize] public List<NextPlane> NextPlanes = new List<NextPlane>();
   }

   [Serializable]
   public class NextPlane
   {
      public PlaneSO Key;
      public int Value;
   }
}
