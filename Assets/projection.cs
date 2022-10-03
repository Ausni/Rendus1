using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projection : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int nombrecube;
    [SerializeField] private float rayon;
    [SerializeField] private GameObject prefab;

    int nombrecubeavant; 

    void Start()
    {
     nombrecubeavant = nombrecube;
     Instantiate(prefab,new Vector3(0f,0f,0f),
     Quaternion.identity);
     SpawnCubes();
     // Ce cube est au centre du cercle pour montré l'origine
    }
     private void SpawnCubes() {
        float alpha=0;
        float y=0;
        float x=0;
        alpha=360/nombrecube;

        // calcule l'angle entre 2 cubes et le cube du centre(origine)
        for(int i=0;i<nombrecube;i++){
        x=Mathf.Cos(i*alpha)*rayon; 
        // les coordonnées suivant l'axe x du cube
        y=Mathf.Sin(i*alpha)*rayon;
        // les coordonnées suivant l'axe y du cube
        Instantiate(prefab,new Vector3(x,y,0f),
        Quaternion.identity); 
        // Place chaque cube à la bonne position autour du cube de centre
        }
    }

    // Update is called once per frame
    void Update()
    {    
    if (nombrecube != nombrecubeavant) {
        SpawnCubes();

        } else {
            // On fait rien
            
        }
        nombrecubeavant = nombrecube;
       
    }

   
}
