import serial
from struct import pack
from random import randint, uniform
from secrets import token_bytes
import math

ser = serial.Serial('COM3')

while True:
    strg = bytes(f'Hello, World! {randint(0, 100)} \0', 'ascii')

    data = pack(f'<2h10p{len(strg)}sQd', randint(0, 10), 0, token_bytes(10), strg, randint(0, 10000000), math.pi)
    ser.write(data)
