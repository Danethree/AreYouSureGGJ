﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class VectorData : MonoBehaviour
{
     public int next = 0;//colocado na posição do vetor de personagem.
   public int previous = 0;
   public int vectorLastPosition;
   public static VectorData vectorData;
   public int pointsNbr;
    public  Image[] characterImage;
    public PointsCount pointsCountScript;
    void Awake()
    {
      
        pointsNbr = pointsCountScript.pointsNbr;
    }

   /*A CADA ACERTO OU ERRO, É PASSADO PARA O PRÓXIMO PERSONAGEM*/
   
     public void afterChooseObject()
    {
       
         next +=1;
         previous = next - 1;
        characterImage[next].enabled = true;
        characterImage[previous].enabled = false;
        if(next == vectorLastPosition)
        {
            pointsCountScript.transferPointsDataGameOver();
             SceneManager.LoadScene(4);
        }
       

    }
}
