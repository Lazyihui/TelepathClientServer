using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using Telepathy;

public class Main : MonoBehaviour {
    Telepathy.Client client = new Telepathy.Client(1024);
    Telepathy.Server server = new Telepathy.Server(1024);
    void Start() {
        Debug.Log("Hello World");

        Application.runInBackground = true;//允许在后台运行

    }

    void Update() {

    }
}
