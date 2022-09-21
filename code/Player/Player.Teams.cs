namespace Sandbox;

/// <summary>
/// Awesome player for my game.
/// </summary>
partial class MyPlayer 
{
	public bool ChangeTeam( MyTeam team, bool autoTeam, bool silent, bool autobalance = false )
	{
		return base.ChangeTeam( (int)team, autoTeam, silent, autobalance );
	}
}
