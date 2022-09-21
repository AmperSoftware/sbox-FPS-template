namespace Sandbox;

partial class MyGame
{	
	public override void DeclareGameTeams()
	{
		// This declares team 0 and 1 (unassigned and spectator)
		base.DeclareGameTeams();

		// Declare the teams you want in your game here.
		TeamManager.DeclareTeam( (int)MyTeam.Player, "players", "Players", Color.Yellow );
	}
}

/// <summary>
/// This is the enum that contains the teams in your game.
/// of entries 
/// </summary>
public enum MyTeam
{
	Unassigned,
	Spectator,

	// Add your teams here.
	Player
}

/// <summary>
/// This is the enum you can use to specify team relations 
/// in Hammer. 
/// I.e. if spawn point belongs to any team
/// or a specific one.
/// </summary>
public enum EditorMyTeamOption
{
	Any,

	// Add your teams here.
	Player
}

public static class MyTeamExtensions
{
	public static string GetTag( this MyTeam team ) => TeamManager.GetTag( (int)team );
	public static string GetName( this MyTeam team ) => TeamManager.GetName( (int)team );
	public static string GetTitle( this MyTeam team ) => TeamManager.GetTitle( (int)team );
	public static bool IsJoinable( this MyTeam team ) => TeamManager.IsJoinable( (int)team );
	public static bool IsPlayable( this MyTeam team ) => TeamManager.IsPlayable( (int)team );
	public static Color GetColor( this MyTeam team ) => TeamManager.GetColor( (int)team );

	public static bool Is( this EditorMyTeamOption option, MyTeam team )
	{
		var teamFromOption = option.ToTeam();
		if ( teamFromOption == MyTeam.Unassigned )
			return true;

		return team == teamFromOption;
	}

	public static MyTeam ToTeam( this EditorMyTeamOption option )
	{
		if ( option == EditorMyTeamOption.Any )
			return MyTeam.Unassigned;

		return (MyTeam)(option + 1);
	}
}
