global using Amper.FPS;

namespace Sandbox;

public partial class MyGame : Amper.FPS.SDKGame
{	
	public static new MyGame Current { get; set; }

	public MyGame()
	{
		Current = this;
	}

	public override SDKPlayer CreatePlayerForClient( Client cl ) => new MyPlayer();
}
