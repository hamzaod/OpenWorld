using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerNetworkSetup : NetworkBehaviour {


    public override void OnStartLocalPlayer()
    {
        GetComponent<CharchterControllerr>().enabled = true;
        
    }

}
