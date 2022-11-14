from math import atan2,tau
from random import randint

for i in range(0,30):
    x1 = randint(-100,100)
    y1 = randint(-100,100)
    x2 = randint(-100,100)
    y2 = randint(-100,100)

    x3 = x2 - x1 
    y3 = y2 - y1

    a = atan2(y3,x3) / tau
    if (a < 0) : a = a + 1

    print("start:({0},{1}) end:({2},{3}) Tau: {4}".format(x1,y1,x2,y2,a))
    


