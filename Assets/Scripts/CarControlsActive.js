var carControl : GameObject;
var aiControls : GameObject;

function Start() {
    var car = carControl.GetComponent("CarController") as MonoBehaviour;
    car.enabled = true;
    var ai = aiControls.GetComponent("CarController") as MonoBehaviour;
    ai.enabled = true;
}

