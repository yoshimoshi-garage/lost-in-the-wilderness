using Meadow;
using Meadow.Devices;
using Meadow.Hardware;
using System.Threading.Tasks;

namespace Day01.F7Feather;

// Videos:
// Original inventr.io:     https://www.youtube.com/watch?v=lsZ7LWDnEoE
// Yoshimaker port:         // TO BE RECORDED

public class MeadowApp : App<F7CoreComputeV2>
{
    private IDigitalOutputPort _led;

    public override Task Initialize()
    {
        _led = Device
            .Pins
            .D01
            .CreateDigitalOutputPort(); // equivalent (sort-of) of Arduino's `pinMode()` command

        return base.Initialize();
    }

    public override async Task Run()
    {
        while (true)
        {
            _led.State = true;      // equivalent (sort-of) of Arduino's `digitalWrite()` command
            await Task.Delay(1000);
            _led.State = false;
            await Task.Delay(1000);
        }
    }
}