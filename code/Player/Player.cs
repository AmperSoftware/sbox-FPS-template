namespace Sandbox;

/// <summary>
/// Awesome player for my game.
/// </summary>
public partial class MyPlayer : SDKPlayer
{
	public new static MyPlayer LocalPlayer => Local.Pawn as MyPlayer;

	public override void Spawn()
	{
		base.Spawn();

		// This sets the player's team to player when they initially spawn.
		// If you make a multiplayer game you probably want to remove this and keep them
		// in unassigned team until they choose their team through some team changing UI.

		// Also keep in mind that if you keep player in unassigned team, they will 
		// stay in spectator mode.
		ChangeTeam( MyTeam.Player, true, true );
	}

	public override void Respawn()
	{
		base.Respawn();

		// We have been respawned! But it doesn't mean
		// that we are currently an active player. We might be a spectator.
		// Check if we are alive and ready to play and then do all the epic 
		// stuff like setting the model and giving weapon.
		if ( !IsAlive )
			return;

		SetModel( "models/citizen/citizen.vmdl" );
		ManageDefaultWeapons();
	}


	public virtual void ManageDefaultWeapons()
	{
		// When we respawn we want to delete all
		// our weapons and regenerate new ones.
		DeleteAllWeapons();
		EquipWeapon( new Pistol(), true );
	}

	public override SDKViewModel CreateViewModel() => new MyViewModel();
}
