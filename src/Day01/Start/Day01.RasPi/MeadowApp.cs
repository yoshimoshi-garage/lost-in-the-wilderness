using Meadow;

namespace Day01.RasPi;

// Debugger Extension: https://marketplace.visualstudio.com/items?itemName=SuessLabs.VSLinuxDebugger
//
// Videos:
// Original inventr.io:     https://www.youtube.com/watch?v=lsZ7LWDnEoE
// Yoshimaker port:         // TO BE RECORDED

internal class MeadowApp : App<RaspberryPi>
{
    public override Task Initialize()
    {
        return base.Initialize();
    }

    public override Task Run()
    {
        return base.Run();
    }

    private static async void Main(string[] args)
    {
        // required to start the Meadow stack, create the Device, Pins, etc
        await MeadowOS.Start(args);
    }
}
