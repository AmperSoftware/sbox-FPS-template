namespace Sandbox;

public partial class MySpawnPoint : SDKSpawnPoint
{
	public override bool CanSpawn( SDKPlayer player )
	{
		// Make only one team be able to spawn on this spawn point?
		return base.CanSpawn( player );
	}
}
