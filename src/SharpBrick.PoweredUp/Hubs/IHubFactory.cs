using System;

namespace SharpBrick.PoweredUp.Hubs
{
    public interface IHubFactory
    {
        Hub CreateByBluetoothManufacturerData(byte[] manufacturerData);
        THub Create<THub>() where THub : class;
    }
}