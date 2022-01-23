using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemyReference;
    private GameObject Ene,lv2;
    private int randomIndex, randomSide;
    int level=1;
    [SerializeField]
    private Transform left, right;


    // Start is called before the first frame update
    void Start()

    {
        level = Gamemanager.instance.CharIndex;
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemy()
    {

        while (true)
        {

            yield return new WaitForSeconds(Random.Range(3-level, 10-(level*2)));

            randomIndex = Random.Range(0, enemyReference.Length);
            randomSide = Random.Range(0, 2);

            Ene = Instantiate(enemyReference[randomIndex]);

         
            if (randomSide == 0)
            {

                Ene.transform.position = left.position;
                Ene.GetComponent<Enemyy>().speed = Random.Range(2+(level*2),7+(level*4));

            }
            else
            {
               
                Ene.transform.position = right.position;
                Ene.GetComponent<Enemyy>().speed = -Random.Range(2+(level*2),7+(level*4));
                Ene.transform.localScale = new Vector3(-1f, 1f, 1f);

            }

        }

    }

}
