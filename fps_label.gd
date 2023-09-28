extends Label

var exact_fps : float
var fps_count : int

func _ready():
	pass

func _process(delta):
	exact_fps += (1 / delta);
	fps_count += 1
	
	if (fps_count >= 60):
		exact_fps = (exact_fps / 60)
		self.text = "FPS :" + str(int(exact_fps))
		exact_fps = 0
		fps_count = 0
	pass
