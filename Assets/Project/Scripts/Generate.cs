using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
   [SerializeField] GameObject rocksPrefab;
   float interval = 2f;
   private void Start() 
   {
    InvokeRepeating("CreateObstacle", 1f, 2f);
      StartCoroutine(ScoreCoroutine());
   }

   private void CreateObstacle()
   {
      //Score.score++;
    Instantiate(rocksPrefab);
   }

   private IEnumerator ScoreCoroutine(){
      yield return new WaitForSeconds(3f);
      while (true){
         yield return new WaitForSeconds(interval);
         Score.score++;
      }
   }
}
