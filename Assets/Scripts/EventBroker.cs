using System;

public class EventBroker
{
    public static event Action ProjectileOutOfBounds;
    public static void CallProjectileOutOfBounds()
    {
        ProjectileOutOfBounds?.Invoke();
    }

}
