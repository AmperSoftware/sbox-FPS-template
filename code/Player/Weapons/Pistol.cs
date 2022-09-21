namespace Sandbox;

public partial class Pistol : SDKWeapon
{
	public override void Spawn()
	{
		base.Spawn();

		SetModel( "weapons/rust_pistol/rust_pistol.vmdl" );
		Regenerate();
	}

	// Attributes
	public override string GetViewModelPath() => "weapons/rust_pistol/v_rust_pistol.vmdl";
	public override float GetAttackTime() => 0.2f;
	public override float GetReloadTime() => 1f;

	public override float GetDeployTime() => 0.5f;
	public override int GetClipSize() => 16;
	public override int GetReserveSize() => 100;
	public override bool IsReloadingEntireClip() => true;

	public override void SetupAnimParameters()
	{

		// Make citizen wield pistol.
		SendPlayerAnimParameter( "holdtype", 1 );
	}

	public override void PlayAttackSound()
	{
		PlaySound( "weapons/rust_pistol/sound/rust_pistol.shoot.sound" );
	}

}
