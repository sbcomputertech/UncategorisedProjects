package;

import flixel.util.FlxSave;
import flixel.FlxG;
import flixel.FlxGame;
import openfl.display.Sprite;

class Main extends Sprite
{
	public function new()
	{
		super();
		addChild(new FlxGame(320, 240, MenuState));
		var startFullscreen:Bool = false;
		var save = new FlxSave();
		save.bind("TurnBasedRPG");
		if (save.data.volume != null)
		{
			FlxG.sound.volume = save.data.volume;
		}
		#if desktop
		if (save.data.fullscreen != null)
		{
			startFullscreen = save.data.fullscreen;
		}
		#end
		save.close();
	}
}
