using Meadow;
using Meadow.Hardware;

namespace Day01.RasPi;

// Videos:
// Original inventr.io:     https://www.youtube.com/watch?v=lsZ7LWDnEoE
// Yoshimaker port:         // TO BE RECORDED

internal class MeadowApp : App<RaspberryPi>
{
    private IDigitalOutputPort _led;

    public override Task Initialize()
    {
        _led = Device
            .Pins
            .GPIO8
            .CreateDigitalOutputPort(); // equivalent (sort-of) of Arduino's `pinMode()` command

        return base.Initialize();
    }

    public override async Task Run()
    {
        while (true)
        {
            Resolver.Log.Info("HIGH");
            _led.State = true;      // equivalent (sort-of) of Arduino's `digitalWrite()` command
            await Task.Delay(1000);
            _led.State = false;
            await Task.Delay(1000);
        }
    }

    private static async Task Main(string[] args)
    {
        // required to start the Meadow stack, create the Device, Pins, etc
        await MeadowOS.Start(args);
    }
}
