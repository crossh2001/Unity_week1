using UnityEngine;
using System.Collections;

public class Lava : MonoBehaviour {

    void OnTriggerEnter(Collider other){
        print("Fall into Lava");
    }
}
