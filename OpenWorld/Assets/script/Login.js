#pragma strict

var pseudo : String = "";
var mdp : String ="";

var mpseudo : String = "";
var mmdp : String ="";

function OnGUI(){
    GUI.Box(Rect(Screen.width/2-110,Screen.height/2-60,220,115),"Log in:");
    GUI.Label(Rect(Screen.width/2-100,Screen.height/2-30,100,20),"Pseudo:");
    pseudo = GUI.TextField(Rect(Screen.width/2,Screen.height/2-30,100,20),pseudo);

    GUI.Label(Rect(Screen.width/2-100,Screen.height/2-5,100,20),"Password:");
    mdp = GUI.PasswordField(Rect(Screen.width/2,Screen.height/2-5,100,20),mdp,"*"[0]);

    if(GUI.Button(Rect(Screen.width/2-50,Screen.height/2+25,100,20),"Se connecter:")){
        login();
    
    }





    GUI.Box(Rect(Screen.width/2+120,Screen.height/2-60,220,115),"Creation du compte:");
    GUI.Label(Rect(Screen.width/2+130,Screen.height/2-30,100,20),"Pseudo:");
    mpseudo = GUI.TextField(Rect(Screen.width/2+230,Screen.height/2-30,100,20),mpseudo);

    GUI.Label(Rect(Screen.width/2+130,Screen.height/2-5,100,20),"Password:");
    mmdp = GUI.PasswordField(Rect(Screen.width/2+230,Screen.height/2-5,100,20),mmdp,"*"[0]);

    if(GUI.Button(Rect(Screen.width/2+160,Screen.height/2+25,100,20),"Se connecter:")){
        creationCompte();
    
    }










}

function login(){
    var www = new WWW("http://localhost/openWorld/connexion.php?pseudo=" + pseudo + "&mdp=" +mdp);
    yield www;
    print(www.text);
}

function creationCompte(){
    var www = new WWW("http://localhost/openWorld/createCompte.php?pseudo=" + mpseudo + "&mdp=" +mmdp);
    yield www;
    print(www.text);
}

