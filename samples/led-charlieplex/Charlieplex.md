# Charlieplex Table

The following table demonstrates the scheme that is used for charlieplexing.

## Support for 2 pins

| LED  | Pin A | Pin B |
| ---- | ----- | ----- |
| LED1 | 1 | 0 |
| LED2 | 0 | 1 |


## Support for 6 pins

The following pins

| LED  | Pin A | Pin B | Pin C |
| ---- | ----- | ----- | ----- |
| LED1 | 1 | 0 | X |
| LED2 | 0 | 1 | X |
| LED3 | X | 1 | 0 |
| LED4 | X | 0 | 1 |
| LED5 | 1 | X | 0 | 
| LED6 | 0 | X | 1 |

## Support for 12 pins

The following pins

| LED   | Pin A | Pin B | Pin C | Pin D |
| ----- | ----- | ----- | ----- | ----- |
| LED1  | 1 | 0 | X | X |
| LED2  | 0 | 1 | X | X |
| LED3  | X | 1 | 0 | X |
| LED4  | X | 0 | 1 | X |
| LED5  | X | X | 1 | 0 |
| LED6  | X | X | 0 | 1 |
| LED7  | 0 | X | 1 | 0 |
| LED8  | 0 | X | 1 | X |
| LED9  | X | 1 | X | 0 |
| LED10 | X | 0 | X | 1 |
| LED11 | 1 | X | X | 0 |
| LED12 | 0 | X | X | 1 |


## Pins Required to support given number of LEDs

From Wikipedia

If the number of LEDs is known, then the previous equation can be worked backwards to determine the number of pins required:

| Pins | LEDs |
| ---- | ---- |
| 1      0    |
| 2    | 2    |
| 3	   | 6    |
| 4	   | 12   |
| 5	   | 20   |
| 6	   | 30   |
| 7	   | 42   |
| 8	   | 56   |
| 9	   | 72   |
| 10   | 90   |
| 20   | 380  |
| 40   | 1560 |
| n	   | n2 − n |
