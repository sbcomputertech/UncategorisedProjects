package;

import flixel.system.FlxSound;
import flixel.FlxG;
import flixel.math.FlxVelocity;
import flixel.math.FlxPoint;
import flixel.FlxSprite;

using flixel.util.FlxSpriteUtil;

enum EnemyType
{
	REGULAR;
	BOSS;
}

class Enemy extends FlxSprite
{
	var SPEED:Float;
	var stepSound:FlxSound;
	public var type:EnemyType;

	var brain:FSM;
	var idleTimer:Float;
	var moveDirection:Float;
	public var seesPlayer:Bool;
	public var playerPosition:FlxPoint;

	public function new(x:Float, y:Float, type:EnemyType)
	{
		super(x, y);
		this.type = type;
		var graphic = if (type == BOSS) AssetPaths.boss__png else AssetPaths.enemy__png;
		loadGraphic(graphic, true, 16, 16);
		setFacingFlip(LEFT, false, false);
		setFacingFlip(RIGHT, true, false);
		animation.add("d", [0, 1, 0, 2], 6, false);
		animation.add("lr", [3, 4, 3, 5], 6, false);
		animation.add("u", [6, 7, 6, 8], 6, false);
		drag.x = drag.y = 10;
		width = 8;
		height = 14;
		offset.x = 4;
		offset.y = 2;

		brain = new FSM(idle);
		idleTimer = 0;
		playerPosition = FlxPoint.get();

		SPEED = FlxG.random.float(90, 130);

		stepSound = FlxG.sound.load(AssetPaths.step__wav, 0.4);
		stepSound.proximity(x, y, FlxG.camera.target, FlxG.width * 0.6);
	}

	override public function update(elapsed:Float)
	{
		if ((velocity.x != 0 || velocity.y != 0) && touching == NONE)
		{
			if (Math.abs(velocity.x) > Math.abs(velocity.y))
			{
				if (velocity.x < 0)
					facing = LEFT;
				else
					facing = RIGHT;
			}
			else
			{
				if (velocity.y < 0)
					facing = UP;
				else
					facing = DOWN;
			}

			switch (facing)
			{
				case LEFT, RIGHT:
					animation.play("lr");

				case UP:
					animation.play("u");

				case DOWN:
					animation.play("d");

				case _:
			}
		}
		if ((velocity.x != 0 || velocity.y != 0) && touching == NONE)
		{
			stepSound.setPosition(x + frameWidth / 2, y + height);
			stepSound.play();
		}

		brain.update(elapsed);
		super.update(elapsed);
		if (this.isFlickering())
			return;
	}
	function idle(elapsed:Float)
	{
		if (seesPlayer)
		{
			brain.activeState = chase;
		}
		else if (idleTimer <= 0)
		{
			if (FlxG.random.bool(1))
			{
				moveDirection = -1;
				velocity.x = velocity.y = 0;
			}
			else
			{
				moveDirection = FlxG.random.int(0, 8) * 45;

				velocity.set(SPEED * 0.5, 0);
				velocity.rotate(FlxPoint.weak(), moveDirection);
			}
			idleTimer = FlxG.random.int(1, 4);
		}
		else
			idleTimer -= elapsed;
	}

	function chase(elapsed:Float)
	{
		if (!seesPlayer)
		{
			brain.activeState = idle;
		}
		else
		{
			FlxVelocity.moveTowardsPoint(this, playerPosition, Std.int(SPEED));
		}
	}
	public function changeType(type:EnemyType)
	{
		if (this.type != type)
		{
			this.type = type;
			var graphic = if (type == BOSS) AssetPaths.boss__png else AssetPaths.enemy__png;
			loadGraphic(graphic, true, 16, 16);
		}
	}
}
