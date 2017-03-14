private var letterPause = 0.05;
var sound : AudioClip;
public var myText : String = "For thousands of years, the Millennium Aged Race lived peacefully on their planet." + "\n" + 
"They were a simple people, preferring to use primitive tools and weapons and abhorring technological advancement." + "\n" + 
"One day, great metal ships began to fall out of the sky, filled with colonists and their robotic assistants. Eager to plunder the surrounding landscape of its precious minerals and gems, the invaders, calling themselves the SAR, or Space Aged Race, pushed aside the native MAR onto tiny reservations while they mined away at the great hills and mountains.";
 
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