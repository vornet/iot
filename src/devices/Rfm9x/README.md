# Adafruit RFM9X - LoRa (Long Range) Transceiver
The Adafruit RFM9X LoRa transceiver is a long range packet radio transmitter and receiver.  It has many application including sending telemetry and remote control.

The code is based off https://github.com/adafruit/Adafruit_CircuitPython_RFM9x, which based off RadioHead.

## Sensor Image

![](sensor.jpg)

## Wiring

It's an SPI-only device, so requires enabling SPI in the Raspberry PI along with the following wiring:

-----------------------------
RFM9X | Raspberry PI Mapping
-----------------------------
VIN   | Either the 3.3V or 5V pin
GND   | GND pin
SCK   | SCK
MISO  | MISO
MOSI  | MOSI
CS    | CS
RST   | Available GPIO Pin

## Usage

Sending a message:
```C#
// TODO
```

Receiving messages:
```C#
// TODO
```

## References
https://cdn.sparkfun.com/assets/learn_tutorials/8/0/4/RFM95_96_97_98W.pdf
