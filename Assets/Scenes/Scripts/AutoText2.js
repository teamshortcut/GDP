private var letterPause = 0.05;
var sound : AudioClip;
private var myText : String = "Eager to plunder the surrounding landscape of its precious minerals and gems, the invaders, calling" + "\n" + "themselves the SAR, or Space Aged Race, pushed aside the native MAR onto tiny reservations" + "\n" + "while they mined away at the great hills and mountains.";
 
function Start () {    
        TypeText ();
}
 
function TypeText () {
        for (var letter in myText.ToCharArray()) {
                GetComponent.<GUIText>().text += letter;
                if (sound)
                        GetComponent.<AudioSource>().PlayOneShot (sound);
                        yield WaitForSeconds (letterPause);
        }              
}