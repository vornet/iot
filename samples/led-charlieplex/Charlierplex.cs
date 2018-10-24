using System;
using System.Collections.Generic;
using System.Devices.Gpio;

public class Charlieplexer
{
    private int[] _pins;
    private int _pinCount;
    private int _maxLeds;

    public Charlieplexer(params  int[] pins)
    {
        _pins = pins;
        _pinCount = pins.Length;
        _maxLeds = (_pinCount * _pinCount) - _pinCount;
    }

    public void Write(PinValue value)
    {
        var pinLayout = new List<int[]>(_maxLeds);

        // first entry
        var precedingPin = new int[_pinCount];
        pinLayout.Add(precedingPin);

        precedingPin[0] = 1;
        precedingPin[1] = 0;

        for (int i = 2; i < _pinCount; i ++)
        {
            precedingPin[i] = -1;
        }

        // add all other entries
        for(int i = 0; i < _maxLeds; i++)
        {
            var layout = new int[_pinCount];


        }
    }

    private void Init()
    {
        
    }
}
