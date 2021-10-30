
public class Constants
{
    // scenes
    public const string SceneBattle = "Battle";
    public const string SceneMenu = "MainMenu";

    // gun types
    public const string Pistol = "Pistol";
    public const string Shotgun = "Shotgun";
    public const string AssaultRifle = "AssaultRifle";

    // robot types
    public const string RedRobot = "RedRobot";
    public const string BlueRobot = "BlueRobot";
    public const string YellowRobot = "YellowRobot";

    // pickup types
    public const int PickUpPistolAmmo = 1;
    public const int PickUpAssualtRifleAmmo = 2;
    public const int PickUpShotgunAmmo = 3;
    public const int PickUpHealth = 4;
    public const int PickUpArmor = 5;

    // misc
    public const string Game = "Game";
    public const float CameraDefaultZoom = 60f;

    public static readonly int[] AllPickupTypes = new int[5]
    {
        PickUpPistolAmmo,
        PickUpAssualtRifleAmmo,
        PickUpShotgunAmmo,
        PickUpHealth,
        PickUpArmor
    };
}
